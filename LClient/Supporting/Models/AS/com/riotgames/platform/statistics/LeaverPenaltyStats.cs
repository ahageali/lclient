using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class LeaverPenaltyStats
{
public object lastLevelIncrease { get; set; }
public Int32 level { get; set; }
public object lastDecay { get; set; }
public Int32 dataVersion { get; set; }
public Boolean userInformed { get; set; }
public Int32 points { get; set; }
public object futureData { get; set; }
}
}