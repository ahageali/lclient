using System;
using System.Collections.Generic;

namespace com.riotgames.platform.messaging
{
[Serializable]
public class StoreAccountBalanceNotification
{
public Double rp { get; set; }
public Double ip { get; set; }
}
}