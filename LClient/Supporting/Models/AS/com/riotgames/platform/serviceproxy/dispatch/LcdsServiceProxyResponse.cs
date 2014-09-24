using System;
using System.Collections.Generic;

namespace com.riotgames.platform.serviceproxy.dispatch
{
[Serializable]
public class LcdsServiceProxyResponse
{
public String status { get; set; }
public String payload { get; set; }
public String messageId { get; set; }
public String methodName { get; set; }
public String serviceName { get; set; }
}
}