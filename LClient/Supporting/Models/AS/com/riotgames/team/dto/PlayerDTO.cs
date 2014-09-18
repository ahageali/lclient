using System;
using System.Collections.Generic;

namespace com.riotgames.team.dto
{
[Serializable]
class PlayerDTO
{
public Double playerId { get; set; }
public object[] teamsSummary { get; set; }
public object[] createdTeams { get; set; }
public object[] playerTeams { get; set; }
}
}