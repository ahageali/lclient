using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
public class SummonerLevelAndPoints
{
public Double infPoints { get; set; }
public Int32 dataVersion { get; set; }
public Double expPoints { get; set; }
public Double summonerLevel { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}