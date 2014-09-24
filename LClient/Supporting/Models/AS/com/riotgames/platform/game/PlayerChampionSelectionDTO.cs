using System;
using System.Collections.Generic;

namespace com.riotgames.platform.game
{
[Serializable]
public class PlayerChampionSelectionDTO
{
public String summonerInternalName { get; set; }
public Int32 dataVersion { get; set; }
public Double spell2Id { get; set; }
public Int32 selectedSkinIndex { get; set; }
public Int32 championId { get; set; }
public Double spell1Id { get; set; }
public object futureData { get; set; }
}
}