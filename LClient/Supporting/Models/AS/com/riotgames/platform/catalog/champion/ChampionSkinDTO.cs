using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog.champion
{
[Serializable]
public class ChampionSkinDTO
{
public Boolean lastSelected { get; set; }
public Boolean stillObtainable { get; set; }
public Double purchaseDate { get; set; }
public Int32 winCountRemaining { get; set; }
public Double endDate { get; set; }
public Int32 championId { get; set; }
public Boolean freeToPlayReward { get; set; }
public Int32 skinId { get; set; }
public Boolean owned { get; set; }
}
}