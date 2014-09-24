using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.runes
{
[Serializable]
public class SummonerRuneInventory
{
public Int32 dataVersion { get; set; }
public object summonerRunesJson { get; set; }
public String dateString { get; set; }
public object[] summonerRunes { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}