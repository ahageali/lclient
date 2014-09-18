using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class RawStat
{
public String statType { get; set; }
public Int32 dataVersion { get; set; }
public Double value { get; set; }
public object futureData { get; set; }
}
}