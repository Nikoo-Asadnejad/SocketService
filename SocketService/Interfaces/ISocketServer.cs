using SocketService.Models;

namespace SocketService.Interfaces;

public interface ISocketServer<T>
{
    public Task<T> Recieve(SocketServerSetting socketServerSetting);
}