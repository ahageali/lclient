using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog
{
[Serializable]
public class Effect
{
public Int32 effectId { get; set; }
public String gameCode { get; set; }
public Int32 dataVersion { get; set; }
public String name { get; set; }
public object categoryId { get; set; }
public com.riotgames.platform.catalog.runes.RuneType runeType { get; set; }
public object futureData { get; set; }
}
}