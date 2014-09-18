using System;
using System.Collections.Generic;

namespace com.riotgames.platform.login
{
[Serializable]
class AuthenticationCredentials
{
public String authToken { get; set; }
public String domain { get; set; }
public object partnerCredentials { get; set; }
public object securityAnswer { get; set; }
public String locale { get; set; }
public String username { get; set; }
public String macAddress { get; set; }
public String clientVersion { get; set; }
public String password { get; set; }
public object oldPassword { get; set; }
public String operatingSystem { get; set; }
}
}