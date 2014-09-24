using System;
using System.Collections.Generic;

namespace com.riotgames.platform.game
{
[Serializable]
public class GameDTO
{
public String spectatorsAllowed { get; set; }
public Boolean passwordSet { get; set; }
public object[] practiceGameRewardsDisabledReasons { get; set; }
public String gameType { get; set; }
public Int32 gameTypeConfigId { get; set; }
public object glmGameId { get; set; }
public String gameState { get; set; }
public object glmHost { get; set; }
public object[] observers { get; set; }
public String statusOfParticipants { get; set; }
public Int32 glmSecurePort { get; set; }
public Double id { get; set; }
public object ownerSummary { get; set; }
public object teamTwoPickOutcome { get; set; }
public object[] teamTwo { get; set; }
public object[] bannedChampions { get; set; }
public Int32 dataVersion { get; set; }
public String roomName { get; set; }
public String name { get; set; }
public Int32 spectatorDelay { get; set; }
public object[] teamOne { get; set; }
public String terminatedCondition { get; set; }
public String queueTypeName { get; set; }
public com.riotgames.platform.game.FeaturedGameInfo featuredGameInfo { get; set; }
public Int32 glmPort { get; set; }
public object passbackUrl { get; set; }
public String roomPassword { get; set; }
public Double optimisticLock { get; set; }
public object teamOnePickOutcome { get; set; }
public Int32 maxNumPlayers { get; set; }
public Int32 queuePosition { get; set; }
public String terminatedConditionString { get; set; }
public object futureData { get; set; }
public String gameMode { get; set; }
public Double expiryTime { get; set; }
public Int32 mapId { get; set; }
public object[] banOrder { get; set; }
public Int32 pickTurn { get; set; }
public String gameStateString { get; set; }
public object[] playerChampionSelections { get; set; }
public object[] gameMutators { get; set; }
public Int32 joinTimerDuration { get; set; }
public object passbackDataPacket { get; set; }
}
}