using System;
using System.Collections.Generic;

namespace com.riotgames.team.stats
{
[Serializable]
public class TeamStatDetail
{
public Int32 maxRating { get; set; }
public Int32 dataVersion { get; set; }
public String teamIdString { get; set; }
public Int32 seedRating { get; set; }
public Int32 losses { get; set; }
public Int32 rating { get; set; }
public String teamStatTypeString { get; set; }
public Int32 averageGamesPlayed { get; set; }
public com.riotgames.team.TeamId teamId { get; set; }
public Int32 wins { get; set; }
public String teamStatType { get; set; }
public object futureData { get; set; }
}
}