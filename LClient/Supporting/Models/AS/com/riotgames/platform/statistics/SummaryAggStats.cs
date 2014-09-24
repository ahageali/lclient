using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class SummaryAggStats
{
public object statsJson { get; set; }
public Int32 dataVersion { get; set; }
public object[] stats { get; set; }
public object futureData { get; set; }
}
}