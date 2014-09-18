using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class RawStatDTO
{
public Int32 dataVersion { get; set; }
public Double value { get; set; }
public String statTypeName { get; set; }
public object futureData { get; set; }
}
}