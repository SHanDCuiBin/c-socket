using System;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketUtil.SocketServer server = new SocketUtil.SocketServer(8888);
            server.StartListen();
            Console.ReadKey();
        }
    }
}
