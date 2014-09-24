using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog.runes
{
[Serializable]
public class RuneType
{
public Int32 runeTypeId { get; set; }
public Int32 dataVersion { get; set; }
public String name { get; set; }
public object futureData { get; set; }
}
}