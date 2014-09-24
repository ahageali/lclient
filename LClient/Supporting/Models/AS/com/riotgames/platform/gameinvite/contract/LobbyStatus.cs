using System;
using System.Collections.Generic;

namespace com.riotgames.platform.gameinvite.contract
{
[Serializable]
public class LobbyStatus
{
public String chatKey { get; set; }
public String gameMetaData { get; set; }
public com.riotgames.platform.gameinvite.contract.Player owner { get; set; }
public object[] members { get; set; }
public object[] invitees { get; set; }
public String invitationId { get; set; }
}
}