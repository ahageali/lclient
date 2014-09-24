using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class ChampionStatInfo
{
public Int32 totalGamesPlayed { get; set; }
public Double accountId { get; set; }
public Int32 dataVersion { get; set; }
public object[] stats { get; set; }
public Double championId { get; set; }
public object futureData { get; set; }
}
}