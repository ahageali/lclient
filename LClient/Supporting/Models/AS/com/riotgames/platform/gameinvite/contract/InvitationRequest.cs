using System;
using System.Collections.Generic;

namespace com.riotgames.platform.gameinvite.contract
{
[Serializable]
public class InvitationRequest
{
public com.riotgames.platform.gameinvite.contract.Inviter inviter { get; set; }
public String inviteType { get; set; }
public String gameMetaData { get; set; }
public com.riotgames.platform.gameinvite.contract.Player owner { get; set; }
public String invitationStateAsString { get; set; }
public String invitationState { get; set; }
public String inviteTypeAsString { get; set; }
public String invitationId { get; set; }
}
}