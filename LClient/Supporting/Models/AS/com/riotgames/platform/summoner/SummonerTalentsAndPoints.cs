using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
public class SummonerTalentsAndPoints
{
public Int32 talentPoints { get; set; }
public Int32 dataVersion { get; set; }
public object modifyDate { get; set; }
public object createDate { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}