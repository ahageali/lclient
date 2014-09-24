using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
public class EndOfGameStats
{
public Int32 talentPointsGained { get; set; }
public Boolean ranked { get; set; }
public Boolean leveledUp { get; set; }
public Int32 skinIndex { get; set; }
public Int32 queueBonusEarned { get; set; }
public String gameType { get; set; }
public Double experienceEarned { get; set; }
public Boolean imbalancedTeamsNoPoints { get; set; }
public object[] teamPlayerParticipantStats { get; set; }
public Int32 basePoints { get; set; }
public Double reportGameId { get; set; }
public String difficulty { get; set; }
public Double gameLength { get; set; }
public Double boostXpEarned { get; set; }
public Boolean invalid { get; set; }
public object otherTeamInfo { get; set; }
public String roomName { get; set; }
public Int32 customMinutesLeftToday { get; set; }
public Double userId { get; set; }
public object[] pointsPenalties { get; set; }
public Int32 coOpVsAiMinutesLeftToday { get; set; }
public object[] otherTeamPlayerParticipantStats { get; set; }
public Double loyaltyBoostIpEarned { get; set; }
public Double rpEarned { get; set; }
public Int32 completionBonusPoints { get; set; }
public Double coOpVsAiMsecsUntilReset { get; set; }
public Double boostIpEarned { get; set; }
public object[] newSpells { get; set; }
public Double experienceTotal { get; set; }
public Double gameId { get; set; }
public Double timeUntilNextFirstWinBonus { get; set; }
public Double loyaltyBoostXpEarned { get; set; }
public String roomPassword { get; set; }
public Int32 elo { get; set; }
public Double ipEarned { get; set; }
public Double firstWinBonus { get; set; }
public Boolean sendStatsToTournamentProvider { get; set; }
public Int32 eloChange { get; set; }
public String gameMode { get; set; }
public object myTeamInfo { get; set; }
public String queueType { get; set; }
public Int32 odinBonusIp { get; set; }
public object[] gameMutators { get; set; }
public object myTeamStatus { get; set; }
public Double ipTotal { get; set; }
public object summonerName { get; set; }
public Double customMsecsUntilReset { get; set; }
}
}