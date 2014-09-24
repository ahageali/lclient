using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class SummaryAggStat
{
public String statType { get; set; }
public Double count { get; set; }
public Int32 dataVersion { get; set; }
public Double value { get; set; }
public object futureData { get; set; }
}
}