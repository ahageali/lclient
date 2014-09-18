using System;
using System.Collections.Generic;

namespace com.riotgames.platform.matchmaking
{
[Serializable]
class GameQueueConfig
{
public Int32 blockedMinutesThreshold { get; set; }
public Int32 minimumParticipantListSize { get; set; }
public Boolean ranked { get; set; }
public Int32 maxLevel { get; set; }
public Boolean thresholdEnabled { get; set; }
public Int32 gameTypeConfigId { get; set; }
public Int32 minLevel { get; set; }
public String queueState { get; set; }
public String type { get; set; }
public String cacheName { get; set; }
public Double id { get; set; }
public String queueBonusKey { get; set; }
public Int32 dataVersion { get; set; }
public Int32 maxSummonerLevelForFirstWinOfTheDay { get; set; }
public String queueStateString { get; set; }
public String pointsConfigKey { get; set; }
public Boolean teamOnly { get; set; }
public Int32 minimumQueueDodgeDelayTime { get; set; }
public Boolean randomizeTeamSides { get; set; }
public object[] supportedMapIds { get; set; }
public object futureData { get; set; }
public String gameMode { get; set; }
public String typeString { get; set; }
public Int32 numPlayersPerTeam { get; set; }
public Boolean disallowFreeChampions { get; set; }
public Int32 maximumParticipantListSize { get; set; }
public String mapSelectionAlgorithm { get; set; }
public Boolean botsCanSpawnOnBlueSide { get; set; }
public object[] gameMutators { get; set; }
public Double thresholdSize { get; set; }
public com.riotgames.platform.matchmaking.MatchingThrottleConfig matchingThrottleConfig { get; set; }
}
}