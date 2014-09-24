using System;
using System.Collections.Generic;

namespace com.riotgames.platform.summoner.spellbook
{
[Serializable]
public class SlotEntry
{
public Int32 dataVersion { get; set; }
public Int32 runeId { get; set; }
public Int32 runeSlotId { get; set; }
public com.riotgames.platform.summoner.RuneSlot runeSlot { get; set; }
public com.riotgames.platform.catalog.runes.Rune rune { get; set; }
public object futureData { get; set; }
}
}