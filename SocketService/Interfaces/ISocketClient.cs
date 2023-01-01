using SocketService.Models;

namespace SocketService.Interfaces;

public interface ISocketClient<T>
{ 
    Task SendAsync(SocketSetting setting, T message);
}