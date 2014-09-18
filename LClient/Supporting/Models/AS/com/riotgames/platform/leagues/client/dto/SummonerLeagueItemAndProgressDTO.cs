using System;
using System.Collections.Generic;

namespace com.riotgames.platform.leagues.client.dto
{
[Serializable]
class SummonerLeagueItemAndProgressDTO
{
public com.riotgames.platform.leagues.client.dto.SummonerLeagueRewardsDTO summonerRewards { get; set; }
public object[] summonerLeagues { get; set; }
public object highestTierQueueType { get; set; }
public object highestTierParticipantId { get; set; }
}
}