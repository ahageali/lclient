using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.masterybook
{
[Serializable]
class TalentEntry
{
public Int32 rank { get; set; }
public Int32 talentId { get; set; }
public Int32 dataVersion { get; set; }
public com.riotgames.platform.summoner.Talent talent { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}