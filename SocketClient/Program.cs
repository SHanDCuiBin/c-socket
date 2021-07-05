using System;


namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketUtil.SocketClient client = new SocketUtil.SocketClient(8888);
            client.StartClient();
            Console.ReadKey();
        }
    }
}
