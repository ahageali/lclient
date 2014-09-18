using System;
using System.Collections.Generic;

namespace com.riotgames.team
{
[Serializable]
class TeamInfo
{
public Double secondsUntilEligibleForDeletion { get; set; }
public String memberStatusString { get; set; }
public Int32 dataVersion { get; set; }
public String tag { get; set; }
public String name { get; set; }
public String memberStatus { get; set; }
public com.riotgames.team.TeamId teamId { get; set; }
public object futureData { get; set; }
}
}