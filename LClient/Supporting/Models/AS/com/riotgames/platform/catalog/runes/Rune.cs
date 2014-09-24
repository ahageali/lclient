using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog.runes
{
[Serializable]
public class Rune
{
public object imagePath { get; set; }
public object toolTip { get; set; }
public Int32 tier { get; set; }
public Int32 itemId { get; set; }
public com.riotgames.platform.catalog.runes.RuneType runeType { get; set; }
public object futureData { get; set; }
public Int32 duration { get; set; }
public Int32 gameCode { get; set; }
public object[] itemEffects { get; set; }
public String baseType { get; set; }
public Int32 dataVersion { get; set; }
public String description { get; set; }
public String name { get; set; }
public object uses { get; set; }
}
}