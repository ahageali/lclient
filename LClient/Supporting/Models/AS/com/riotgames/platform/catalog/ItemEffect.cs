using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog
{
[Serializable]
class ItemEffect
{
public Int32 effectId { get; set; }
public Int32 itemEffectId { get; set; }
public com.riotgames.platform.catalog.Effect effect { get; set; }
public Int32 dataVersion { get; set; }
public String value { get; set; }
public Int32 itemId { get; set; }
public object futureData { get; set; }
}
}