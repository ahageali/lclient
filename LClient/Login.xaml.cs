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

                                break;
                            case "QUEUE":
                                //TODO finish this
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
