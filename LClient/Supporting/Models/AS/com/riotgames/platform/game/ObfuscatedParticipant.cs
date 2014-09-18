using System;
using System.Collections.Generic;

namespace com.riotgames.platform.game
{
[Serializable]
class ObfuscatedParticipant
{
public Int32 badges { get; set; }
public Int32 index { get; set; }
public Int32 dataVersion { get; set; }
public Boolean clientInSynch { get; set; }
public Int32 gameUniqueId { get; set; }
public Int32 pickMode { get; set; }
public object futureData { get; set; }
}
}