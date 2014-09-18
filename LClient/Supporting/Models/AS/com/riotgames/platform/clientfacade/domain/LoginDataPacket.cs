using System;
using System.Collections.Generic;

namespace com.riotgames.platform.clientfacade.domain
{
[Serializable]
class LoginDataPacket
{
public Int32 restrictedGamesRemainingForRanked { get; set; }
public com.riotgames.platform.statistics.PlayerStatSummaries playerStatSummaries { get; set; }
public Int32 restrictedChatGamesRemaining { get; set; }
public Int32 minutesUntilShutdown { get; set; }
public Boolean minor { get; set; }
public Int32 maxPracticeGameSize { get; set; }
public com.riotgames.platform.summoner.SummonerCatalog summonerCatalog { get; set; }
public Double ipBalance { get; set; }
public object reconnectInfo { get; set; }
public object[] languages { get; set; }
public object[] simpleMessages { get; set; }
public com.riotgames.platform.summoner.AllSummonerData allSummonerData { get; set; }
public Int32 customMinutesLeftToday { get; set; }
public object platformGameLifecycleDTO { get; set; }
public Int32 coOpVsAiMinutesLeftToday { get; set; }
public object bingeData { get; set; }
public Boolean inGhostGame { get; set; }
public Int32 leaverPenaltyLevel { get; set; }
public Boolean bingePreventionSystemEnabledForClient { get; set; }
public Int32 pendingBadges { get; set; }
public object broadcastNotification { get; set; }
public Int32 minutesUntilMidnight { get; set; }
public Double timeUntilFirstWinOfDay { get; set; }
public Double coOpVsAiMsecsUntilReset { get; set; }
public object clientSystemStates { get; set; }
public Double bingeMinutesRemaining { get; set; }
public com.riotgames.kudos.dto.PendingKudosDTO pendingKudosDTO { get; set; }
public Int32 leaverBusterPenaltyTime { get; set; }
public String platformId { get; set; }
public String emailStatus { get; set; }
public Boolean matchMakingEnabled { get; set; }
public Boolean minutesUntilShutdownEnabled { get; set; }
public Double rpBalance { get; set; }
public Boolean showEmailVerificationPopup { get; set; }
public Boolean bingeIsPlayerInBingePreventionWindow { get; set; }
public object[] gameTypeConfigs { get; set; }
public Boolean minorShutdownEnforced { get; set; }
public String competitiveRegion { get; set; }
public Double customMsecsUntilReset { get; set; }
}
}