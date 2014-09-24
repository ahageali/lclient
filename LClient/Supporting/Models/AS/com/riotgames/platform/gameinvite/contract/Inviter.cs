using System;
using System.Collections.Generic;

namespace com.riotgames.platform.gameinvite.contract
{
[Serializable]
public class Inviter
{
public String previousSeasonHighestTier { get; set; }
public String summonerName { get; set; }
public Double summonerId { get; set; }
}
}