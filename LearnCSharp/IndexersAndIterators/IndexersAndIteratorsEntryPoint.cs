using System;
using System.Collections.Generic;

namespace LearnCSharp.IndexersAndIterators
{
    public class IndexersAndIteratorsEntryPoint
    {
        public IndexersAndIteratorsEntryPoint()
        {
            var cars = new List<Car>
            {
                new()
                {
                    Name = "Ford",
                    Number = "A001AA01"
                },
                new()
                {
                    Name = "Lada",
                    Number = "B727ET77"
                }
            };

            var parking = new Parking();

            foreach (var car in cars)
                parking.Add(car);

            Console.WriteLine(parking["A001AA01"]?.Name);
            Console.WriteLine(parking["A001AA02"]?.Name);

            foreach (var car in parking)
                Console.WriteLine(car);
        }
    }
}