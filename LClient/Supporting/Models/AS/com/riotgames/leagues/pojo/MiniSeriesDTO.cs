using System;
using System.Collections.Generic;

namespace com.riotgames.leagues.pojo
{
[Serializable]
class MiniSeriesDTO
{
public String progress { get; set; }
public Int32 target { get; set; }
public Int32 losses { get; set; }
public Double timeLeftToPlayMillis { get; set; }
public Int32 wins { get; set; }
}
}