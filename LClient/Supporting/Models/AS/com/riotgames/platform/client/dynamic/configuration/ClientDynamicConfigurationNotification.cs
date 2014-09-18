using System;
using System.Collections.Generic;

namespace com.riotgames.platform.client.dynamic.configuration
{
[Serializable]
class ClientDynamicConfigurationNotification
{
public String configs { get; set; }
public Boolean delta { get; set; }
}
}