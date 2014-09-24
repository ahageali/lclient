using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.riotgames.platform.login
{
    [Serializable]
    public class AuthToken
    {
        public long timestamp { get; set; }
        public String signature { get; set; }
        public String fingerprint { get; set; }
        public String other { get; set; }
        public String resources { get; set; }
        public String uuid { get; set; }
        public long account_id { get; set; }
        public String account_name { get; set; }
    }
}
