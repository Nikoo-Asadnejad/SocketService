namespace SocketService.Interfaces;

public static class IpHelper
{
    public  static async Task<IPAddress> GetIpAddressAsync(string address)
    {
        IPAddress ipAddress;
        IPAddress.TryParse(address, out ipAddress);
        
        // address is not in ip format
        if (ipAddress is null)
        {
            IPHostEntry ipHostInfo = await Dns.GetHostEntryAsync(address); 
            ipAddress = ipHostInfo.AddressList[0];
        }

        return ipAddress;
    }
}