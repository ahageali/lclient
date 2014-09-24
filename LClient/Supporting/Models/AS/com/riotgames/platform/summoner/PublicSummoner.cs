using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
public class PublicSummoner
{
public String internalName { get; set; }
public Int32 dataVersion { get; set; }
public Double acctId { get; set; }
public String name { get; set; }
public Int32 profileIconId { get; set; }
public object revisionDate { get; set; }
public Double revisionId { get; set; }
public Double summonerLevel { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}