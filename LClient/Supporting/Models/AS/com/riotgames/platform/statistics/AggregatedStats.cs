using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class AggregatedStats
{
public object[] lifetimeStatistics { get; set; }
public Int32 dataVersion { get; set; }
public object modifyDate { get; set; }
public object key { get; set; }
public String aggregatedStatsJson { get; set; }
public object futureData { get; set; }
}
}