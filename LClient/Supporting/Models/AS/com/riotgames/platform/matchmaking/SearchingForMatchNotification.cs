using System;
using System.Collections.Generic;

namespace com.riotgames.platform.matchmaking
{
[Serializable]
public class SearchingForMatchNotification
{
public object playerJoinFailures { get; set; }
public object[] ghostGameSummoners { get; set; }
public object[] joinedQueues { get; set; }
}
}