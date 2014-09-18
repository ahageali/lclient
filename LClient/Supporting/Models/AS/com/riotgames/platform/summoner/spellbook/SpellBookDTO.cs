using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.spellbook
{
[Serializable]
class SpellBookDTO
{
public object bookPagesJson { get; set; }
public Int32 dataVersion { get; set; }
public object[] bookPages { get; set; }
public String dateString { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
}
}