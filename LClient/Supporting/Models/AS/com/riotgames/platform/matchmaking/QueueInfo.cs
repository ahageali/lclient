using System;
using System.Collections.Generic;

namespace com.riotgames.platform.matchmaking
{
[Serializable]
public class QueueInfo
{
public Double waitTime { get; set; }
public Double queueId { get; set; }
public Int32 queueLength { get; set; }
}
}