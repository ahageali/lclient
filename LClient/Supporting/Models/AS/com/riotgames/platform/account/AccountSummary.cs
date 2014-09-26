using System;
using System.Collections.Generic;

namespace com.riotgames.platform.account
{
[Serializable]
public class AccountSummary
{
public Int32 groupCount { get; set; }
public String username { get; set; }
public long accountId { get; set; }
public object summonerInternalName { get; set; }
public Int32 dataVersion { get; set; }
public Boolean admin { get; set; }
public Boolean hasBetaAccess { get; set; }
public object summonerName { get; set; }
public Boolean partnerMode { get; set; }
public Boolean needsPasswordReset { get; set; }
public object futureData { get; set; }
}
}