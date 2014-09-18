using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics.team
{
[Serializable]
class TeamAggregatedStatsDTO
{
public String queueType { get; set; }
public String serializedToJson { get; set; }
public object[] playerAggregatedStatsList { get; set; }
public com.riotgames.team.TeamId teamId { get; set; }
}
}