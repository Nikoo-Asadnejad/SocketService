using SocketService.Interfaces;
using SocketService.Models;

namespace SocketService.Services;

public class SocketServer<T> : ISocketServer<T>
{
    public Task<T> Recieve(SocketServerSetting socketServerSetting)
    {
        throw new NotImplementedException();
    }
}