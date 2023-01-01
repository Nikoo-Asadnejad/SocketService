namespace SocketService.Models;

public class SocketSetting
{
    public SocketSetting(string address, 
                        int port,
                        SocketType socketType = SocketType.Stream,
                        ProtocolType protocolType = ProtocolType.Tcp )
    {
        this.Address = address;
        this.port = port;
        this.ProtocolType = protocolType;
        this.SocketType = socketType;
    }

    public string Address { get; set; }
    
    public int port { get; set; }
    public SocketType SocketType { get; set; }
    public ProtocolType ProtocolType { get; set; }
}