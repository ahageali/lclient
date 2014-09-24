using System;
using System.Collections.Generic;

namespace com.riotgames.platform.game
{
[Serializable]
public class PlayerParticipant
{
public Double accountId { get; set; }
public Int32 queueRating { get; set; }
public String botDifficulty { get; set; }
public Boolean minor { get; set; }
public object locale { get; set; }
public Int32 lastSelectedSkinIndex { get; set; }
public String partnerId { get; set; }
public Int32 profileIconId { get; set; }
public Boolean rankedTeamGuest { get; set; }
public Double summonerId { get; set; }
public Int32 voterRating { get; set; }
public Int32 dataVersion { get; set; }
public object selectedRole { get; set; }
public Int32 pickMode { get; set; }
public Double teamParticipantId { get; set; }
public Double timeAddedToQueue { get; set; }
public Int32 index { get; set; }
public Double originalAccountNumber { get; set; }
public String summonerInternalName { get; set; }
public Double adjustmentFlags { get; set; }
public Boolean teamOwner { get; set; }
public object futureData { get; set; }
public Int32 badges { get; set; }
public Int32 teamRating { get; set; }
public Int32 pickTurn { get; set; }
public Boolean clientInSynch { get; set; }
public String summonerName { get; set; }
public String originalPlatformId { get; set; }
public object selectedPosition { get; set; }
}
}