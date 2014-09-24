using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog.champion
{
[Serializable]
public class ChampionDTO
{
public Double purchased { get; set; }
public object[] championSkins { get; set; }
public Boolean rankedPlayEnabled { get; set; }
public Double purchaseDate { get; set; }
public Int32 winCountRemaining { get; set; }
public Boolean botEnabled { get; set; }
public Boolean active { get; set; }
public Double endDate { get; set; }
public Boolean freeToPlay { get; set; }
public Int32 championId { get; set; }
public Boolean freeToPlayReward { get; set; }
public Boolean owned { get; set; }
}
}