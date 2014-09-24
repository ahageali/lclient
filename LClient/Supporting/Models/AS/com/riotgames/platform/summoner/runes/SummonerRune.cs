using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.runes
{
[Serializable]
public class SummonerRune
{
public object purchased { get; set; }
public Int32 dataVersion { get; set; }
public object purchaseDate { get; set; }
public Int32 runeId { get; set; }
public Int32 quantity { get; set; }
public com.riotgames.platform.catalog.runes.Rune rune { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}