using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog.icon
{
[Serializable]
class Icon
{
public object imagePath { get; set; }
public object toolTip { get; set; }
public object tier { get; set; }
public Int32 itemId { get; set; }
public object futureData { get; set; }
public object duration { get; set; }
public Int32 gameCode { get; set; }
public object itemEffects { get; set; }
public String baseType { get; set; }
public Int32 dataVersion { get; set; }
public object description { get; set; }
public String name { get; set; }
public object uses { get; set; }
public com.riotgames.platform.catalog.icon.IconType iconType { get; set; }
}
}