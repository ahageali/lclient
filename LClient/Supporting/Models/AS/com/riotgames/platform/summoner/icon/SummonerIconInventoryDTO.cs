using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.icon
{
[Serializable]
class SummonerIconInventoryDTO
{
public object[] summonerIcons { get; set; }
public Int32 dataVersion { get; set; }
public String dateString { get; set; }
public Double summonerId { get; set; }
public object summonerIconJson { get; set; }
public object futureData { get; set; }
}
}