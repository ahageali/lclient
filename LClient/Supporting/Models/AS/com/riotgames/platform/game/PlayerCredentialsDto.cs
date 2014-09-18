using System;
using System.Collections.Generic;

namespace com.riotgames.platform.game
{
[Serializable]
class PlayerCredentialsDto
{
public String encryptionKey { get; set; }
public Double gameId { get; set; }
public Int32 lastSelectedSkinIndex { get; set; }
public String serverIp { get; set; }
public Boolean observer { get; set; }
public Double summonerId { get; set; }
public object futureData { get; set; }
public String observerServerIp { get; set; }
public Int32 dataVersion { get; set; }
public String handshakeToken { get; set; }
public Double playerId { get; set; }
public Int32 serverPort { get; set; }
public Int32 observerServerPort { get; set; }
public String summonerName { get; set; }
public String observerEncryptionKey { get; set; }
public Int32 championId { get; set; }
}
}