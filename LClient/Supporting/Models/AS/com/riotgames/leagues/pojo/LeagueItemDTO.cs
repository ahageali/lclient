using System;
using System.Collections.Generic;

namespace com.riotgames.leagues.pojo
{
[Serializable]
class LeagueItemDTO
{
public Int32 previousDayLeaguePosition { get; set; }
public Double timeLastDecayMessageShown { get; set; }
public Boolean hotStreak { get; set; }
public String leagueName { get; set; }
public object miniSeries { get; set; }
public String tier { get; set; }
public Boolean freshBlood { get; set; }
public Double lastPlayed { get; set; }
public String playerOrTeamId { get; set; }
public Int32 leaguePoints { get; set; }
public Int32 demotionWarning { get; set; }
public Boolean inactive { get; set; }
public String rank { get; set; }
public Boolean veteran { get; set; }
public String queueType { get; set; }
public Int32 losses { get; set; }
public Double timeUntilDecay { get; set; }
public Boolean displayDecayWarning { get; set; }
public String playerOrTeamName { get; set; }
public Int32 wins { get; set; }
}
}