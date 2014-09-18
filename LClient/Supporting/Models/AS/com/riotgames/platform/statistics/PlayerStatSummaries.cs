using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class PlayerStatSummaries
{
public Int32 season { get; set; }
public Int32 dataVersion { get; set; }
public object[] playerStatSummarySet { get; set; }
public Double userId { get; set; }
public object futureData { get; set; }
}
}