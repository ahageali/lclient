using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class TimeTrackedStat
{
public object timestamp { get; set; }
public Int32 dataVersion { get; set; }
public String type { get; set; }
public object futureData { get; set; }
}
}