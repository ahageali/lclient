using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class RecentGames
{
public object recentGamesJson { get; set; }
public Dictionary<string, object> playerGameStatsMap { get; set; }
public object[] gameStatistics { get; set; }
public Int32 dataVersion { get; set; }
public Double userId { get; set; }
public object futureData { get; set; }
}
}