using System;
using System.Collections.Generic;

namespace com.riotgames.leagues.pojo
{
[Serializable]
class LeagueListDTO
{
public String queue { get; set; }
public String name { get; set; }
public String tier { get; set; }
public String requestorsRank { get; set; }
public object[] entries { get; set; }
public Double nextApexUpdate { get; set; }
public Int32 maxLeagueSize { get; set; }
public object requestorsName { get; set; }
}
}