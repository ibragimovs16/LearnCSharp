using System;

namespace LearnCSharp.AnonymousTypeAndTuple
{
    public class Tuples
    {
        public Tuples()
        {
            var tuple = new Tuple<int, string>(5, "Hello");
            Console.WriteLine(tuple.Item1);

            var tuple2 = (5, "Hello");
            Console.WriteLine(tuple2.Item2);

            var tuple3 = (Name: "Tomato", Energy: 20);
            Console.WriteLine(tuple3);

            var result = GetData();
            Console.WriteLine(result);
        }

        public static (int Number, string Name, bool Flag) GetData()
        {
            var number = 5;
            var name = Guid.NewGuid().ToString();
            var flag = number > 4;

            return (number, name, flag);
        }
    }
}