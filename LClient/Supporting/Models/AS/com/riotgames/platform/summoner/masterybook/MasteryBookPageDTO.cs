using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.masterybook
{
[Serializable]
public class MasteryBookPageDTO
{
public object[] talentEntries { get; set; }
public Int32 dataVersion { get; set; }
public Double pageId { get; set; }
public String name { get; set; }
public Boolean current { get; set; }
public object createDate { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}