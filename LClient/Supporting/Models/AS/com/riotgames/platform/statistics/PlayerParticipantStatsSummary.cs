using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class PlayerParticipantStatsSummary
{
public String skinName { get; set; }
public Double gameId { get; set; }
public Int32 profileIconId { get; set; }
public Int32 elo { get; set; }
public Boolean leaver { get; set; }
public Double leaves { get; set; }
public Double teamId { get; set; }
public Int32 eloChange { get; set; }
public object[] statistics { get; set; }
public Double level { get; set; }
public Boolean botPlayer { get; set; }
public Double userId { get; set; }
public Double spell2Id { get; set; }
public Double losses { get; set; }
public String summonerName { get; set; }
public Double wins { get; set; }
public Double spell1Id { get; set; }
}
}