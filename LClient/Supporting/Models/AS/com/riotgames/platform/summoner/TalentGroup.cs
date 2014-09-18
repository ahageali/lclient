using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
class TalentGroup
{
public Int32 index { get; set; }
public object[] talentRows { get; set; }
public Int32 dataVersion { get; set; }
public String name { get; set; }
public Int32 tltGroupId { get; set; }
public object futureData { get; set; }
}
}