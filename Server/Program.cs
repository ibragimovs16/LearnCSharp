using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. TCP\n2. UDP\nChoose: ");
            var type = Console.ReadLine();

            if (type is null) return;
            switch (int.Parse(type))
            {
                case 1:
                    _ = new Tcp();
                    break;
                case 2:
                    _ = new Udp();
                    break;
            }
        }
    }
}