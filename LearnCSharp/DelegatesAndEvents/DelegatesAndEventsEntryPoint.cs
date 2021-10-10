using System;

namespace LearnCSharp.DelegatesAndEvents
{
    public class DelegatesAndEventsEntryPoint
    {
        public DelegatesAndEventsEntryPoint()
        {
            Console.WriteLine("[*] Delegates:");
            _ = new Delegates();

            Console.WriteLine("\n\n[*] Events:");
            _ = new Events();
        }
    }
}
