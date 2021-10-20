using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp.IndexersAndIterators
{
    public class Parking : IEnumerable
    {
        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;
        
        // модификатор_доступа тип_возвращаемого this[тип индекс]
        // {
        //     ...
        // }

        public Car this[string number] => _cars.FirstOrDefault(c => c.Number == number);

        public int Count => _cars.Count;
        public string Name { get; set; }

        public int Add(Car car)
        {
            if (car is null) throw new ArgumentNullException(nameof(car), "Car is null.");
            if (Count >= MAX_CARS) return -1;
            
            _cars.Add(car);
            return _cars.Count - 1;
        }

        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) throw new ArgumentNullException(nameof(number), "null");

            var car = _cars.FirstOrDefault(c => c.Number == number);
            if (car != null) _cars.Remove(car);
        }

        public IEnumerator GetEnumerator() =>
            _cars.GetEnumerator();
    }
}