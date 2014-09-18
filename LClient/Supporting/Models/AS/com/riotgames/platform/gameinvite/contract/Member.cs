using System;
using System.Collections.Generic;

namespace com.riotgames.platform.gameinvite.contract
{
[Serializable]
class Member
{
public Boolean hasDelegatedInvitePower { get; set; }
public String summonerName { get; set; }
public Double summonerId { get; set; }
}
}