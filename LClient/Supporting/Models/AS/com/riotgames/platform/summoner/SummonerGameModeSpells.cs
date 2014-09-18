using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
class SummonerGameModeSpells
{
public Int32 dataVersion { get; set; }
public Int32 spell2Id { get; set; }
public Int32 spell1Id { get; set; }
public object futureData { get; set; }
}
}