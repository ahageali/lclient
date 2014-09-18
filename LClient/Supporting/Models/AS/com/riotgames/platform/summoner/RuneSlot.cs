using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner
{
[Serializable]
class RuneSlot
{
public Int32 id { get; set; }
public Int32 minLevel { get; set; }
public Int32 dataVersion { get; set; }
public com.riotgames.platform.catalog.runes.RuneType runeType { get; set; }
public object futureData { get; set; }
}
}