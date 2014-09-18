using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LClient.Supporting.Models.HTTP
{
    [Serializable]
    public class Ticker
    {
        public int id { get; set; }
        public int node { get; set; }
        public string champ { get; set; }
        public int current { get; set; }
    }

    [Serializable]
    public class Lqt
    {
        public string other { get; set; }
        public string fingerprint { get; set; }
        public string signature { get; set; }
        public long timestamp { get; set; }
        public string uuid { get; set; }
        public string resources { get; set; }
        public int account_id { get; set; }
        public string account_name { get; set; }
    }

    [Serializable]
    public class InGameCredentials
    {
        public bool inGame { get; set; }
        public object summonerId { get; set; }
        public object serverIp { get; set; }
        public object serverPort { get; set; }
        public object encryptionKey { get; set; }
        public object handshakeToken { get; set; }
    }

    [Serializable]
    public class HTTPLoginResult
    {
        public int node { get; set; }
        public int vcap { get; set; }
        public int rate { get; set; }
        public List<Ticker> tickers { get; set; }
        public int backlog { get; set; }
        public string reason { get; set; }
        public string status { get; set; }
        public string champ { get; set; }
        public Lqt lqt { get; set; }
        public int delay { get; set; }
        public InGameCredentials inGameCredentials { get; set; }
        public string user { get; set; }
    }
}
