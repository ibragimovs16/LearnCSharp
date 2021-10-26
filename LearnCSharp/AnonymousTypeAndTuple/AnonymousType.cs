using System;

namespace LearnCSharp.AnonymousTypeAndTuple
{
    public class AnonymousType
    {
        public AnonymousType()
        {
            var product = new
            {
                Name = "Milk",
                Energy = 60
            };

            var eat = new Eat {Name = "Meat"};

            var product2 = new
            {
                eat.Name,
                Energy = 200
            };

            Console.WriteLine(product);
            Console.WriteLine(product2);
        }
    }
}