
using System.Net.NetworkInformation;
class Program
{
    static void Main(string[] args)
    {
        string targetIP = "46.174.52.237";
        int pingIntervalMinutes = 1; 
        using (Ping ping = new Ping())
        {
            while (true)
            {
                PingReply reply = ping.Send(targetIP);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Ping успешен. Время ответа: {reply.RoundtripTime} мс");
                }
                else
                {
                    Console.WriteLine($"Ping не удался. Состояние: {reply.Status}");
                }
                Thread.Sleep(pingIntervalMinutes * 60 * 1000); 
            }
        }
    }
}
