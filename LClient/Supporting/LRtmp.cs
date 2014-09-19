using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtmpSharp;
using System.Reflection;

namespace LClient.Supporting
{
    class LRtmp
    {
        RtmpSharp.Net.RtmpClient mainClient;
        public String SummonerName {get; set;}

        public LRtmp()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsClass && x.Namespace.StartsWith("com")).ToList();
            RtmpSharp.IO.SerializationContext serialContext = new RtmpSharp.IO.SerializationContext(types);
            mainClient = new RtmpSharp.Net.RtmpClient(new Uri("rtmps://prod.na1.lol.riotgames.com:2099"), serialContext,RtmpSharp.IO.ObjectEncoding.Amf3);
        }

        public async Task<bool> ConnectAsync()
        {
            try
            {
                await mainClient.ConnectAsync();
                return true;
            }
            catch(Exception excep)
            {
                System.Windows.MessageBox.Show("connect:" + excep.ToString());
            }
            return false;
        }

        public async Task<bool> LoginAsync(com.riotgames.platform.login.AuthenticationCredentials cred)
        {
            try
            {
                com.riotgames.platform.login.Session session = await mainClient.InvokeAsync<com.riotgames.platform.login.Session>("my-rtmps", "loginService", "login", cred);
                await mainClient.SubscribeAsync("my-rtmps", "messagingDestination", "bc", "bc-" + session.accountSummary.accountId);
                await mainClient.SubscribeAsync("my-rtmps", "messagingDestination", "gn-" + session.accountSummary.accountId, "gn-" + session.accountSummary.accountId);
                await mainClient.SubscribeAsync("my-rtmps", "messagingDestination", "cn-" + session.accountSummary.accountId, "cn-" + session.accountSummary.accountId);
                return await mainClient.LoginAsync(cred.username, session.token);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("login:" + e.ToString());
            }
            return false;
        }

        public async Task<com.riotgames.platform.clientfacade.domain.LoginDataPacket> GetLoginDataPacketAsync()
        {
            return await mainClient.InvokeAsync<com.riotgames.platform.clientfacade.domain.LoginDataPacket>("getLoginDataPacketForUser", new object[] { });
        }
    }
}
