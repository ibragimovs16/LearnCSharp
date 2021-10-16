using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp.LINQ
{
    public class LinqWithCollections
    {
        public LinqWithCollections()
        {
            var collection = new List<int>();

            for (int i = 0; i < 10; i++)
                collection.Add(i);

            var result =
                from item in collection
                where item < 5
                select item;

            var result2 = collection.Where(item => item < 5);

            foreach (var item in result)
                Console.WriteLine(item);

            Console.WriteLine();
            
            foreach (var item in result2)
                Console.WriteLine(item);
        }
    }
}