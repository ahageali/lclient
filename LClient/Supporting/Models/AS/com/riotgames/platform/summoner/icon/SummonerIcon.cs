using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.icon
{
[Serializable]
class SummonerIcon
{
public com.riotgames.platform.catalog.icon.Icon icon { get; set; }
public Int32 dataVersion { get; set; }
public object purchaseDate { get; set; }
public Int32 iconId { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}