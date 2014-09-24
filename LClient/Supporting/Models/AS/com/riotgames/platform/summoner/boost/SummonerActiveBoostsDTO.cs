using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.boost
{
[Serializable]
public class SummonerActiveBoostsDTO
{
public Double xpBoostEndDate { get; set; }
public Int32 xpBoostPerWinCount { get; set; }
public Int32 xpLoyaltyBoost { get; set; }
public Int32 ipBoostPerWinCount { get; set; }
public Int32 ipLoyaltyBoost { get; set; }
public Double summonerId { get; set; }
public Double ipBoostEndDate { get; set; }
}
}