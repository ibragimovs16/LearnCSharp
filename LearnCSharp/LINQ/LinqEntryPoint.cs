using System;

namespace LearnCSharp.LINQ
{
    public class LinqEntryPoint
    {
        public LinqEntryPoint()
        {
            _ = new LinqWithCollections();
            Console.WriteLine();
            _ = new LinqWithClass();

            Console.ReadKey();
        }
    }
}