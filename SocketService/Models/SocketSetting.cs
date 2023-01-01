namespace SocketService.Models;

public class SocketSetting
{
    public SocketSetting(string address, 
                        SocketType socketType = SocketType.Stream,
                        ProtocolType protocolType = ProtocolType.Tcp )
    {
        this.Address = address;
        this.ProtocolType = protocolType;
        this.SocketType = socketType;
    }

    public string Address { get; set; }
    public SocketType SocketType { get; set; }
    public ProtocolType ProtocolType { get; set; }
}