using System;
using System.Collections.Generic;

namespace com.riotgames.team
{
[Serializable]
class CreatedTeam
{
public Double timeStamp { get; set; }
public Int32 dataVersion { get; set; }
public com.riotgames.team.TeamId teamId { get; set; }
public object futureData { get; set; }
}
}