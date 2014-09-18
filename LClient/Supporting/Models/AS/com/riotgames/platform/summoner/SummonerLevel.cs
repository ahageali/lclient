using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
class SummonerLevel
{
public Double expTierMod { get; set; }
public Double grantRp { get; set; }
public Double expForLoss { get; set; }
public Int32 dataVersion { get; set; }
public Double summonerTier { get; set; }
public Double infTierMod { get; set; }
public Double expToNextLevel { get; set; }
public Double expForWin { get; set; }
public Double summonerLevel { get; set; }
public object futureData { get; set; }
}
}