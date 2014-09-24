using System;
using System.Collections.Generic;

namespace com.riotgames.platform.game
{
[Serializable]
public class FeaturedGameInfo
{
public Int32 dataVersion { get; set; }
public object[] championVoteInfoList { get; set; }
public object futureData { get; set; }
}
}