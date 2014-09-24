using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class PlayerGameStats
{
public String skinName { get; set; }
public Boolean ranked { get; set; }
public Boolean leveledUp { get; set; }
public Int32 skinIndex { get; set; }
public object[] fellowPlayers { get; set; }
public String gameType { get; set; }
public Double experienceEarned { get; set; }
public object rawStatsJson { get; set; }
public Boolean eligibleFirstWinOfDay { get; set; }
public String difficulty { get; set; }
public Int32 gameMapId { get; set; }
public Boolean leaver { get; set; }
public Double spell1 { get; set; }
public String gameTypeEnum { get; set; }
public Double teamId { get; set; }
public Double summonerId { get; set; }
public object[] statistics { get; set; }
public Double spell2 { get; set; }
public Boolean afk { get; set; }
public Double id { get; set; }
public Int32 voterRating { get; set; }
public Double boostXpEarned { get; set; }
public Double level { get; set; }
public Boolean invalid { get; set; }
public Int32 dataVersion { get; set; }
public Double userId { get; set; }
public object createDate { get; set; }
public Int32 userServerPing { get; set; }
public Int32 adjustedRating { get; set; }
public Int32 premadeSize { get; set; }
public Double boostIpEarned { get; set; }
public Double gameId { get; set; }
public Int32 timeInQueue { get; set; }
public Double ipEarned { get; set; }
public Double ratingAuditFlags { get; set; }
public Int32 eloChange { get; set; }
public object futureData { get; set; }
public String gameMode { get; set; }
public String difficultyString { get; set; }
public Double KCoefficient { get; set; }
public Int32 teamRating { get; set; }
public String subType { get; set; }
public String queueType { get; set; }
public object[] gameMutators { get; set; }
public Boolean premadeTeam { get; set; }
public Double predictedWinPct { get; set; }
public Double rating { get; set; }
public Double championId { get; set; }
}
}