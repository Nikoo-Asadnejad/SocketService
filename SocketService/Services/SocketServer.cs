using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using SocketService.Interfaces;
using SocketService.Models;

namespace SocketService.Services;

public class SocketServer<T> : ISocketServer<T>
{
    public async Task<T> Recieve(SocketServerSetting socketServerSetting)
    {
        IPAddress ipAddress = await IpHelper.GetIpAddressAsync(socketServerSetting.Address);
        IPEndPoint ipEndPoint = new(ipAddress, port: socketServerSetting.port);
        
        using Socket listener = new(
            ipEndPoint.AddressFamily,
            socketServerSetting.SocketType,
            socketServerSetting.ProtocolType);

        listener.Bind(ipEndPoint);
        listener.Listen(backlog: socketServerSetting.ConnectionThreshold);

        Socket handler = await listener.AcceptAsync();
        
        byte[] ackBuffer = new byte[1_024];
        int received = await handler.ReceiveAsync(ackBuffer, SocketFlags.None);
        string recievedMessage = Encoding.UTF8.GetString(ackBuffer, 0, received);
        T result = JsonConvert.DeserializeObject<T>(recievedMessage);
        return result;
    }
    
}