using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics.team
{
[Serializable]
class TeamPlayerAggregatedStatsDTO
{
public Double playerId { get; set; }
public com.riotgames.platform.statistics.AggregatedStats aggregatedStats { get; set; }
public com.riotgames.team.TeamId teamId { get; set; }
public String teamStatType { get; set; }
}
}