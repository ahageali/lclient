using System;
using System.Collections.Generic;

namespace com.riotgames.platform.statistics
{
[Serializable]
class PlayerStats
{
public object[] timeTrackedStats { get; set; }
public Int32 promoGamesPlayed { get; set; }
public Int32 dataVersion { get; set; }
public object promoGamesPlayedLastUpdated { get; set; }
public object futureData { get; set; }
}
}