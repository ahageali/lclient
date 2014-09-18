using System;
using System.Collections.Generic;

namespace com.riotgames.platform.game
{
[Serializable]
class GameTypeConfigDTO
{
public Boolean allowTrades { get; set; }
public Int32 banTimerDuration { get; set; }
public Int32 maxAllowableBans { get; set; }
public Boolean crossTeamChampionPool { get; set; }
public Boolean teamChampionPool { get; set; }
public object futureData { get; set; }
public Int32 postPickTimerDuration { get; set; }
public Int32 id { get; set; }
public Boolean duplicatePick { get; set; }
public Int32 dataVersion { get; set; }
public Boolean exclusivePick { get; set; }
public Int32 mainPickTimerDuration { get; set; }
public String name { get; set; }
public String pickMode { get; set; }
}
}