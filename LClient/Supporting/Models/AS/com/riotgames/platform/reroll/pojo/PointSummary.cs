using System;
using System.Collections.Generic;

namespace com.riotgames.platform.reroll.pojo
{
[Serializable]
class PointSummary
{
public Double pointsToNextRoll { get; set; }
public Int32 maxRolls { get; set; }
public Int32 numberOfRolls { get; set; }
public Double pointsCostToRoll { get; set; }
public Double currentPoints { get; set; }
}
}