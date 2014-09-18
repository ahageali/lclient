using System;
using System.Collections.Generic;

namespace com.riotgames.team.dto
{
[Serializable]
class TeamDTO
{
public com.riotgames.team.stats.TeamStatSummary teamStatSummary { get; set; }
public String status { get; set; }
public String tag { get; set; }
public com.riotgames.team.dto.RosterDTO roster { get; set; }
public object lastGameDate { get; set; }
public object modifyDate { get; set; }
public object messageOfDay { get; set; }
public com.riotgames.team.TeamId teamId { get; set; }
public object lastJoinDate { get; set; }
public object secondLastJoinDate { get; set; }
public Double secondsUntilEligibleForDeletion { get; set; }
public object[] matchHistory { get; set; }
public String name { get; set; }
public object thirdLastJoinDate { get; set; }
public object createDate { get; set; }
}
}