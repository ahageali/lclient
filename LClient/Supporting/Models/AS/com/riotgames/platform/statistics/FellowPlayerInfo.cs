using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class FellowPlayerInfo
{
public Int32 dataVersion { get; set; }
public Double championId { get; set; }
public Int32 teamId { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}