using Newtonsoft.Json;
using SocketService.Interfaces;
using SocketService.Models;

namespace SocketService.Services;

public class SocketClient<T> : ISocketClient<T>
{
    public async Task SendAsync(SocketSetting socketSetting, T message)
    {
        IPAddress ipAddress = await IpHelper.GetIpAddressAsync(socketSetting.Address);
        IPEndPoint ipEndPoint = new(ipAddress, socketSetting.port);
        
        using Socket client = new(
            ipEndPoint.AddressFamily,
            socketSetting.SocketType,
            socketSetting.ProtocolType);

        await client.ConnectAsync(ipEndPoint);

        string messageString = JsonConvert.SerializeObject(message);
        byte[] messageBytes = Encoding.UTF8.GetBytes(messageString);
        _ = await client.SendAsync(messageBytes, SocketFlags.None);
        
        client.Shutdown(how: SocketShutdown.Both);
    }
}