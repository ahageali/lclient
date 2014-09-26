using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LClient.Supporting.Models.HTTP;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json.Linq;

namespace LClient
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Password)))
            {
                var progressController = await DialogManager.ShowProgressAsync(this, "Logging in", "Contacting HTTP Server");
                WebRequest req = WebRequest.Create("https://lq.na1.lol.riotgames.com/login-queue/rest/queues/lol/authenticate");
                req.ContentType = "application/x-www-form-urlencoded";
                req.Method = "POST";
                req.UseDefaultCredentials = true;
                using (StreamWriter writer = new StreamWriter(await req.GetRequestStreamAsync()))
                {
                    await writer.WriteAsync("payload=user=" + txtUser.Text + ",password=" + txtPass.Password);
                }
                WebResponse resp = null;
                try
                {
                    resp = await req.GetResponseAsync();
                    using (StreamReader reader = new StreamReader(resp.GetResponseStream()))
                    {
                        string strRes = await reader.ReadToEndAsync();
                        HTTPLoginResult res = await Task.Factory.StartNew(() => Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLoginResult>(strRes));
                        switch (res.status)
                        {
                            case "LOGIN":
                                await LoginRTMP(progressController, res);
                                break;
                            case "QUEUE":
                                progressController.SetMessage("In queue");
                                String tickerUrl = "https://lq.na1.lol.riotgames.com/login-queue/rest/queues/lol/ticker/";
                                tickerUrl += res.champ;
                                WebClient webClient = new WebClient();
                                int expectedValue = res.tickers.FirstOrDefault(x=>x.node == res.node).id;
                                while (true)
                                {
                                    String data = webClient.DownloadString(tickerUrl);
                                    JObject obj = JObject.Parse(data);
                                    int value = 0;
                                    int.TryParse((String)obj[res.node.ToString()],System.Globalization.NumberStyles.AllowHexSpecifier,null, out value);
                                    if (value > expectedValue)
                                    {
                                        req = WebRequest.Create("https://lq.na1.lol.riotgames.com/login-queue/rest/queues/lol/token");
                                        req.ContentType = "application/json";
                                        req.Method = "POST";
                                        req.UseDefaultCredentials = true;
                                        using (StreamWriter writer = new StreamWriter(await req.GetRequestStreamAsync()))
                                        {
                                            String serializedLqt = await Task.Factory.StartNew(() => Newtonsoft.Json.JsonConvert.SerializeObject(res.lqt, new Newtonsoft.Json.JsonSerializerSettings() { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore }));
                                            await writer.WriteAsync(serializedLqt);
                                        }
                                        resp = await req.GetResponseAsync();
                                        using (StreamReader queueReader = new StreamReader(resp.GetResponseStream()))
                                        {
                                            String strResult = await queueReader.ReadToEndAsync();
                                            HTTPLoginResult result = await Task.Factory.StartNew(() => Newtonsoft.Json.JsonConvert.DeserializeObject<HTTPLoginResult>(strResult));
                                            res.lqt = result.lqt;
                                        }
                                        await LoginRTMP(progressController, res);
                                        return;
                                    }
                                    await Task.Delay(res.delay);
                                }
                                break;
                            default:
                                await ProgressFailed(progressController, "Invalid Login");
                                break;
                        }
                    }
                    return;
                }
                catch (Exception excep)
                {
                    ProgressFailed(progressController, excep.Message);
                }
            }
        }

        private async Task LoginRTMP(ProgressDialogController controller, HTTPLoginResult res)
        {
            controller.SetMessage("Contacting RTMP Server");
            Supporting.LRtmp rtmpClient = new Supporting.LRtmp();
            await rtmpClient.ConnectAsync();
            com.riotgames.platform.login.AuthenticationCredentials rtmpInfo = new com.riotgames.platform.login.AuthenticationCredentials()
            {
                operatingSystem = "Windows 8",
                username = txtUser.Text,
                domain = "lolclient.lol.riotgames.com",
                clientVersion = "4.17.14_09_22_18_55", //todo: don't hardcode this
                locale = "en_US",
                password = txtPass.Password,
                macAddress = ""
            };
            rtmpInfo.authToken = await Task.Factory.StartNew(() => Newtonsoft.Json.JsonConvert.SerializeObject(new com.riotgames.platform.login.AuthToken
            {
                account_id = res.lqt.account_id,
                account_name = res.lqt.account_name,
                fingerprint = res.lqt.fingerprint,
                other = res.lqt.other,
                resources = res.lqt.resources,
                signature = res.lqt.signature,
                timestamp = res.lqt.timestamp,
                uuid = res.lqt.uuid
            }));
            if (await rtmpClient.LoginAsync(rtmpInfo))
            {
                com.riotgames.platform.clientfacade.domain.LoginDataPacket data = await rtmpClient.GetLoginDataPacketAsync();
                MainWindow mainWindow = new MainWindow(data, rtmpClient);
                mainWindow.Show();
                rtmpClient.PerformHeartBeatLoop();
                this.Close();
                return;
            }
            else
            {
                await ProgressFailed(controller, "Rejected from RTMPS side(?)");
            }
        }

        private async Task ProgressFailed(ProgressDialogController controller, String reason)
        {
            controller.SetMessage("Failure to login: " + reason);
            await Task.Delay(1500);
            await controller.CloseAsync();
        }
    }
}
