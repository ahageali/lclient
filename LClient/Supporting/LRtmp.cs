using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtmpSharp;
using System.Reflection;

namespace LClient.Supporting
{
    public class LRtmp
    {
        RtmpSharp.Net.RtmpClient mainClient;
        public String SummonerName {get; set;}
        public event EventHandler<RtmpSharp.Messaging.MessageReceivedEventArgs> MessageRecieved;
        com.riotgames.platform.login.Session CurrentSession;

        #region Main Stuff
        public LRtmp()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && x.Namespace.StartsWith("com")).ToList();
            RtmpSharp.IO.SerializationContext serialContext = new RtmpSharp.IO.SerializationContext(types);
            mainClient = new RtmpSharp.Net.RtmpClient(new Uri("rtmps://prod.na1.lol.riotgames.com:2099"), serialContext,RtmpSharp.IO.ObjectEncoding.Amf3);
            //mainClient = new RtmpSharp.Net.RtmpClient(new Uri("rtmps://127.0.0.1:2099"), serialContext, RtmpSharp.IO.ObjectEncoding.Amf3);
            mainClient.MessageReceived += RecieveMessage;
        }

        void RecieveMessage(object sender, RtmpSharp.Messaging.MessageReceivedEventArgs e)
        {
            if (MessageRecieved != null)
            {
                MessageRecieved(this,e);
            }
        }

        public Task ConnectAsync()
        {
            return mainClient.ConnectAsync();
        }

        public void Disconnect()
        {
            mainClient.Close();
        }

        #endregion
        #region Login Service
        public async Task<bool> LoginAsync(com.riotgames.platform.login.AuthenticationCredentials cred)
        {
            try
            {
                com.riotgames.platform.login.Session session = await mainClient.InvokeAsync<com.riotgames.platform.login.Session>("my-rtmps","loginService","login", cred);
                CurrentSession = session;
                await mainClient.SubscribeAsync("my-rtmps", "messagingDestination", "bc", "bc-" + session.accountSummary.accountId);
                await mainClient.SubscribeAsync("my-rtmps", "messagingDestination", "gn-" + session.accountSummary.accountId, "gn-" + session.accountSummary.accountId);
                await mainClient.SubscribeAsync("my-rtmps", "messagingDestination", "cn-" + session.accountSummary.accountId, "cn-" + session.accountSummary.accountId);
                return await mainClient.LoginAsync(session.accountSummary.username, session.token);
            }
            catch (Exception e)
            {
                //TODO: handle exceptions properly
                System.Windows.MessageBox.Show("login:" + e.ToString());
            }
            return false;
        }

        public async Task PerformHeartBeatLoop()
        {
            try
            {
                int count = 1;
                while(!mainClient.IsDisconnected)
                {
                    object[] dataToSend = {CurrentSession.accountSummary.accountId, CurrentSession.token, count, DateTime.Now.ToString() }; //TODO properly format this for riot
                    count++;
                    await mainClient.InvokeAsync<int>("my-rtmps", "loginService", "performLCDSHeartBeat", (object[])dataToSend);
                    await Task.Delay(120000); //wait 2 mins before executing again
                }
            }
            catch(Exception e)
            {
                //TODO: handle exceptions properly
                System.Windows.MessageBox.Show("heartbeat:" + e.ToString());
            }
        }

        #endregion

        #region Client Facade Service
        public Task<com.riotgames.platform.clientfacade.domain.LoginDataPacket> GetLoginDataPacketAsync()
        {
            return mainClient.InvokeAsync<com.riotgames.platform.clientfacade.domain.LoginDataPacket>("my-rtmps", "clientFacadeService", "getLoginDataPacketForUser", new object[] { });
        }
        #endregion
    }
}
