using System;
using System.Collections.Generic;

namespace com.riotgames.platform.catalog.icon
{
[Serializable]
class IconType
{
public Int32 iconTypeId { get; set; }
public Int32 dataVersion { get; set; }
public String name { get; set; }
public object futureData { get; set; }
}
}