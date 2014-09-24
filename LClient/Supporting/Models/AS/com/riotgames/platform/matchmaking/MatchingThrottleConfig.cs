using System;
using System.Collections.Generic;

namespace com.riotgames.platform.matchmaking
{
[Serializable]
public class MatchingThrottleConfig
{
public Double limit { get; set; }
public object[] matchingThrottleProperties { get; set; }
public Int32 dataVersion { get; set; }
public String cacheName { get; set; }
public object futureData { get; set; }
}
}