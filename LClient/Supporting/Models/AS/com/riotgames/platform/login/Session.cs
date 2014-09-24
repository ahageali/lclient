using System;
using System.Collections.Generic;

namespace com.riotgames.platform.login
{
[Serializable]
public class Session
{
public String token { get; set; }
public String password { get; set; }
public com.riotgames.platform.account.AccountSummary accountSummary { get; set; }
}
}