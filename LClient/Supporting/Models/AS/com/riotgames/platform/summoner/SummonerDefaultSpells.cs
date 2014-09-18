using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
class SummonerDefaultSpells
{
public Int32 dataVersion { get; set; }
public object summonerDefaultSpellsJson { get; set; }
public ASObject summonerDefaultSpellMap { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}