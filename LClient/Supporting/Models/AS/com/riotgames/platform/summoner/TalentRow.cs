using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
public class TalentRow
{
public Int32 index { get; set; }
public Int32 dataVersion { get; set; }
public object[] talents { get; set; }
public Int32 tltGroupId { get; set; }
public Int32 pointsToActivate { get; set; }
public Int32 tltRowId { get; set; }
public object futureData { get; set; }
}
}