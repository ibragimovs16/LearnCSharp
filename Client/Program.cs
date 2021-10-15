using System;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int tcpPort = 8080;
            const int udpPort = 8081;

            IPEndPoint endPoint;
            Socket socket;

            Console.Write("1. TCP\n2. UDP\nChoose: ");
            var type = Console.ReadLine();

            string message;
            byte[] buffer;
            StringBuilder answer;

            if (type is null) return;
            switch (int.Parse(type))
            {
                case 1:
                    endPoint = new IPEndPoint(IPAddress.Parse(ip), tcpPort);
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    Console.Write("Write your message: ");

                    message = Console.ReadLine();
                    if (message != null)
                    {
                        var data = Encoding.UTF8.GetBytes(message);

                        socket.Connect(endPoint);
                        socket.Send(data);
                    }

                    buffer = new byte[256];
                    answer = new StringBuilder();

                    do
                    {
                        var size = socket.Receive(buffer);
                        answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    } while (socket.Available > 0);

                    Console.WriteLine(answer);

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    break;
                case 2:
                    endPoint = new IPEndPoint(IPAddress.Parse(ip), 8082);
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    socket.Bind(endPoint);

                    Console.Write("Write your message: ");
                    message = Console.ReadLine();
                    if (message != null)
                    {
                        var serverEndPoint = new IPEndPoint(IPAddress.Parse(ip), udpPort);
                        socket.SendTo(Encoding.UTF8.GetBytes(message), serverEndPoint);

                        buffer = new byte[256];
                        answer = new StringBuilder();
                        EndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse(ip), udpPort);

                        do
                        {
                            socket.ReceiveFrom(buffer, ref senderEndPoint);
                            answer.Append(Encoding.UTF8.GetString(buffer));
                        } while (socket.Available > 0);

                        Console.WriteLine(answer);
                    }

                    break;
            }
        }
    }
}