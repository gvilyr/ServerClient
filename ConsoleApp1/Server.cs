using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ConsoleApp1
{
    class Server
    {
        public void listen()
        {
            UdpClient server = new UdpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Any, 33173);
            Console.WriteLine("Command and control server nnnn active");
            EndPoint endPoint = (EndPoint)iPEnd;
            while (true)
            {
                byte[] data = server.Receive(ref iPEnd);
            }
            
        }

    }
}
