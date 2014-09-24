using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
public class Summoner
{
public String internalName { get; set; }
public String previousSeasonHighestTier { get; set; }
public Double acctId { get; set; }
public Boolean helpFlag { get; set; }
public Double sumId { get; set; }
public Int32 profileIconId { get; set; }
public Boolean displayEloQuestionaire { get; set; }
public object lastGameDate { get; set; }
public Boolean advancedTutorialFlag { get; set; }
public object revisionDate { get; set; }
public Double revisionId { get; set; }
public object futureData { get; set; }
public Int32 dataVersion { get; set; }
public String name { get; set; }
public Boolean nameChangeFlag { get; set; }
public Boolean tutorialFlag { get; set; }
}
}