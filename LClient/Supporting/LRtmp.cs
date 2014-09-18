using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RtmpSharp;

namespace LClient.Supporting
{
    class LRtmp
    {
        RtmpSharp.Net.RtmpClient mainClient;
        public String SummonerName {get; set;}

        public LRtmp()
        {
        }

        public async Task<bool> Login(com.riotgames.platform.login.Session session)
        {

            return false;
        }
    }
}
