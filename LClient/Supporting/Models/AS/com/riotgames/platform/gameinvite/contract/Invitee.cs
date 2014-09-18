using System;
using System.Collections.Generic;

namespace com.riotgames.platform.gameinvite.contract
{
[Serializable]
class Invitee
{
public String inviteeStateAsString { get; set; }
public String summonerName { get; set; }
public String inviteeState { get; set; }
public Double summonerId { get; set; }
}
}