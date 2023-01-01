namespace SocketService.Models;

public class SocketServerSetting : SocketSetting
{
    public SocketServerSetting(string address ,
        int connectionThreshold = 1000,
        SocketType socketType = SocketType.Stream, 
        ProtocolType protocolType = ProtocolType.Tcp) : base(address, socketType,protocolType)
    {
        this.ConnectionThreshold = connectionThreshold;
    }
    public int ConnectionThreshold { get; set; }
}