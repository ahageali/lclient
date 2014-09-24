using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
public class AllSummonerData
{
public com.riotgames.platform.summoner.spellbook.SpellBookDTO spellBook { get; set; }
public Int32 dataVersion { get; set; }
public com.riotgames.platform.summoner.SummonerDefaultSpells summonerDefaultSpells { get; set; }
public com.riotgames.platform.summoner.SummonerTalentsAndPoints summonerTalentsAndPoints { get; set; }
public com.riotgames.platform.summoner.Summoner summoner { get; set; }
public com.riotgames.platform.summoner.masterybook.MasteryBookDTO masteryBook { get; set; }
public com.riotgames.platform.summoner.SummonerLevelAndPoints summonerLevelAndPoints { get; set; }
public com.riotgames.platform.summoner.SummonerLevel summonerLevel { get; set; }
public object futureData { get; set; }
}
}