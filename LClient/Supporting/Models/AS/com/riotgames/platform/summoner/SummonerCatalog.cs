using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
public class SummonerCatalog
{
public object items { get; set; }
public object[] talentTree { get; set; }
public object[] spellBookConfig { get; set; }
}
}