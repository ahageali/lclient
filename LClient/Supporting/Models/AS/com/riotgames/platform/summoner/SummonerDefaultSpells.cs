using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
class SummonerDefaultSpells
{
public Int32 dataVersion { get; set; }
public string summonerDefaultSpellsJson { get; set; }
public Dictionary<string, object> summonerDefaultSpellMap { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}