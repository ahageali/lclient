using System;
using System.Collections.Generic;

namespace com.riotgames.team.stats
{
[Serializable]
class TeamStatSummary
{
public Int32 dataVersion { get; set; }
public object[] teamStatDetails { get; set; }
public String teamIdString { get; set; }
public com.riotgames.team.TeamId teamId { get; set; }
public object futureData { get; set; }
}
}