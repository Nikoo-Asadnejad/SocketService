namespace SocketService.Models;

public class SocketServerSetting : SocketSetting
{
    public SocketServerSetting(string address ,
        int port ,
        int connectionThreshold = 1000,
        SocketType socketType = SocketType.Stream, 
        ProtocolType protocolType = ProtocolType.Tcp) : base(address, port,socketType,protocolType)
    {
        this.ConnectionThreshold = connectionThreshold;
    }
    public int ConnectionThreshold { get; set; }
}