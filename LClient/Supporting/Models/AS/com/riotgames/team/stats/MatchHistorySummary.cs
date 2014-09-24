using System;
using System.Collections.Generic;

namespace com.riotgames.team.stats
{
[Serializable]
public class MatchHistorySummary
{
public String gameMode { get; set; }
public Int32 mapId { get; set; }
public Int32 assists { get; set; }
public String opposingTeamName { get; set; }
public Boolean invalid { get; set; }
public Int32 deaths { get; set; }
public Double gameId { get; set; }
public Int32 kills { get; set; }
public Boolean win { get; set; }
public Double date { get; set; }
public Int32 opposingTeamKills { get; set; }
}
}