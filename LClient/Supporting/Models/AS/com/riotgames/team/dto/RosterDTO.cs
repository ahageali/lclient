using System;
using System.Collections.Generic;

namespace com.riotgames.team.dto
{
[Serializable]
public class RosterDTO
{
public Double ownerId { get; set; }
public object[] memberList { get; set; }
}
}