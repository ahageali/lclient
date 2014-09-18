using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
class Talent
{
public Int32 index { get; set; }
public String level5Desc { get; set; }
public Int32 minLevel { get; set; }
public Int32 maxRank { get; set; }
public String level4Desc { get; set; }
public Int32 tltId { get; set; }
public String level3Desc { get; set; }
public object futureData { get; set; }
public Int32 talentGroupId { get; set; }
public Int32 gameCode { get; set; }
public Int32 minTier { get; set; }
public object prereqTalentGameCode { get; set; }
public Int32 dataVersion { get; set; }
public String level2Desc { get; set; }
public String name { get; set; }
public Int32 talentRowId { get; set; }
public String level1Desc { get; set; }
}
}