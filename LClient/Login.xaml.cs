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
                                progressController.SetMessage("Contacting RTMP Server");
                                com.riotgames.platform.login.AuthenticationCredentials rtmpInfo = new com.riotgames.platform.login.AuthenticationCredentials()
                                {
                                    operatingSystem = "Windows 8",
                                    username = txtUser.Text,
                                    domain = "lolclient.lol.riotgames.com",
                                    clientVersion = "4.16.14_09_11_18_16",
                                    locale = "en_US",
                                    password = txtPass.Password,
                                    macAddress = ""
                                };
                                rtmpInfo.authToken = await Task.Factory.StartNew(() => Newtonsoft.Json.JsonConvert.SerializeObject(new com.riotgames.platform.login.AuthToken
                                    {
                                        account_id=res.lqt.account_id,
                                        account_name=res.lqt.account_name,
                                        fingerprint=res.lqt.fingerprint,
                                        other=res.lqt.other,
                                        resources = res.lqt.resources,
                                        signature = res.lqt.signature,
                                        timestamp = res.lqt.timestamp,
                                        uuid = res.lqt.uuid
                                    }));
                                Supporting.LRtmp rtmpClient = new Supporting.LRtmp();
                                if (await rtmpClient.ConnectAsync())
                                {
                                    if (await rtmpClient.LoginAsync(rtmpInfo))
                                    {
                                        com.riotgames.platform.clientfacade.domain.LoginDataPacket data = await rtmpClient.GetLoginDataPacketAsync();

                                    }
                                }
                                break;
                            case "QUEUE":
                                progressController.SetMessage("Got put in queue, too bad i didn't program that yet!");
                                break;
                            default:
                                await ProgressFailed(progressController);
                                break;
                        }
                    }
                    return;
                }
                catch (Exception excep)
                {
                }
                //TODO work on this to specify reason
                await ProgressFailed(progressController);
            }
        }

        private async Task ProgressFailed(ProgressDialogController controller)
        {
            controller.SetMessage("Failed");
            await Task.Delay(1500);
            await controller.CloseAsync();
        }
    }
}
