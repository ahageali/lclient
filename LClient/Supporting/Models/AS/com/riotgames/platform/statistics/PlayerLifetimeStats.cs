using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class PlayerLifetimeStats
{
public com.riotgames.platform.statistics.PlayerStatSummaries playerStatSummaries { get; set; }
public com.riotgames.platform.statistics.LeaverPenaltyStats leaverPenaltyStats { get; set; }
public Int32 dataVersion { get; set; }
public object previousFirstWinOfDay { get; set; }
public Double userId { get; set; }
public Int32 dodgeStreak { get; set; }
public object dodgePenaltyDate { get; set; }
public object playerStatsJson { get; set; }
public com.riotgames.platform.statistics.PlayerStats playerStats { get; set; }
public object futureData { get; set; }
}
}