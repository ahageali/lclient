using System;
using System.Collections.Generic;

namespace com.riotgames.team.dto
{
[Serializable]
class TeamMemberInfoDTO
{
public object joinDate { get; set; }
public object playerName { get; set; }
public object inviteDate { get; set; }
public String status { get; set; }
public Double playerId { get; set; }
}
}