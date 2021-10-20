﻿using System;
using LearnCSharp.DelegatesAndEvents;
using LearnCSharp.ExtensionMethod;
using LearnCSharp.LINQ;
using LearnCSharp.Parallelism;

namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // _ = new DelegatesAndEventsEntryPoint();
            // _ = new ParallelismEntryPoint();
            // _ = new LinqEntryPoint();
            _ = new ExtensionMethodEntryPoint();

            Console.ReadKey();
        }
    }
}
