using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class PlayerStatSummary
{
public Int32 maxRating { get; set; }
public String playerStatSummaryTypeString { get; set; }
public com.riotgames.platform.statistics.SummaryAggStats aggregatedStats { get; set; }
public object modifyDate { get; set; }
public Int32 leaves { get; set; }
public object futureData { get; set; }
public Int32 dataVersion { get; set; }
public String playerStatSummaryType { get; set; }
public Double userId { get; set; }
public Int32 losses { get; set; }
public Int32 rating { get; set; }
public object aggregatedStatsJson { get; set; }
public Int32 wins { get; set; }
}
}