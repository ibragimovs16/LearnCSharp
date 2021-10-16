using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp.LINQ
{
    public class LinqWithClass
    {
        public LinqWithClass()
        {
            var products = new List<Product>();
            var products2 = new List<Product>();
            
            var array = new int[] {1, 2, 3, 4};
            var array2 = new int[] {3, 4, 5, 6};

            for (int i = 0; i < 10; i++)
                products.Add(new Product()
                {
                    Name = $"Product {i}",
                    Energy = new Random().Next(10, 500)
                });

            for (int i = 0; i < 10; i++)
                products2.Add(new Product()
                {
                    Name = $"Product {i}",
                    Energy = new Random().Next(10, 12)
                });

            #region Where

            //  Делаем выборку элементов коллекции, у которых значение Energy меньше 200

            var result = from item in products
                where item.Energy < 200
                select item;

            var result2 = products.Where(item => item.Energy < 200);

            foreach (var item in result)
                Console.WriteLine(item);

            Console.WriteLine();

            foreach (var item in result2)
                Console.WriteLine(item);

            #endregion

            Console.WriteLine();

            #region Select

            // Создаем новую коллекцию в которую добавляем только значения свойства Energy

            var selectCollection = products.Select(product => product.Energy);

            foreach (var item in selectCollection)
                Console.WriteLine(item);

            #endregion

            Console.WriteLine();

            #region OrderBy

            // Сортируем элементы коллекции по значению свойства Energy в порядке возрастания

            var orderByEnergy = products.OrderBy(product => product.Energy);

            // Сортируем элементы коллекции по значению свойства Energy в порядке убывания

            var orderByDescendingEnergy = products.OrderByDescending(product => product.Energy);

            foreach (var item in orderByEnergy)
                Console.WriteLine(item);

            Console.WriteLine();

            foreach (var item in orderByDescendingEnergy)
                Console.WriteLine(item);

            Console.WriteLine();

            // Сортируем элементы коллекции более чем по одному свойству

            var orderByEnergy2 = products2.OrderBy(product => product.Energy)
                .ThenByDescending(product => product.Name);

            foreach (var item in orderByEnergy2)
                Console.WriteLine(item);

            #endregion

            Console.WriteLine();

            #region GroupBy
            
            // Сгруппировать элементы коллекции по значению свойства Energy

            var groupByEnergy = products2.GroupBy(product => product.Energy);

            foreach (var group in groupByEnergy)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var item in group)
                    Console.WriteLine(item);
            }

            #endregion

            Console.WriteLine();

            #region Reverse
            
            // Разворачивает элементы коллекции
            
            products.Reverse();

            foreach (var item in products)
                Console.WriteLine(item);

            #endregion

            Console.WriteLine();

            #region AllAndAny
            
            // Соответствуют ли все элементы коллекции указанному предикату ?
            
            Console.WriteLine(products2.All(item => item.Energy == 10));
            
            // Соотвествует ли хоть один элемент коллекции указанному предикату ?
            
            Console.WriteLine(products2.Any(item => item.Energy == 10));

            #endregion

            Console.WriteLine();

            #region Contains

            // Проверка вхождения элемента в коллекцию

            var prod = new Product();
 
            Console.WriteLine(products2.Contains(products2[5]));
            Console.WriteLine(products2.Contains(prod));

            #endregion

            Console.WriteLine();
            
            #region Distinct

            // Позволяет убрать повторяющиеся элементы

            var arr = new int[] {1, 2, 3, 2, 1, 3, 2, 3, 1};
            var distinct = arr.Distinct();

            #endregion

            #region UnionAndIntersectAndExcept
            
            // Объединение двух коллекций, добавляя в результирующую уникальные значения

            foreach (var item in array)
                Console.WriteLine(item);

            Console.WriteLine();
            
            var union = array.Union(array2);
            
            foreach (var item in union)
                Console.WriteLine(item);

            Console.WriteLine();
            
            // Пересечение двух коллекций
            
            var intersect = array.Intersect(array2);
            
            foreach (var item in intersect)
                Console.WriteLine(item);

            Console.WriteLine();
            
            // Из множества 1 вычесть множество 2

            var except = array.Except(array2);
            
            foreach (var item in except)
                Console.WriteLine(item);

            #endregion

            Console.WriteLine();    
            
            #region Aggregate

            var sum = array.Sum();
            var min = products.Min(product => product.Energy);
            var max = products.Max(product => product.Energy);
            var aggregate = array.Aggregate((x, y) => x * y);

            #endregion

            #region SkipAndTake

            // Пропустить n элементов от начала коллекции

            var arrFromSecondElement = array.Skip(1);
            
            // Пропустить n элементов от начала коллекции и взять k элементов

            var arrFromSecondElementForFifth = array.Skip(1).Take(5);

            #endregion

            #region Выборки

            var first = array.First();
            var last = array.Last();
            
            // Получить элемент коллекции соответсвующий предикату и является единственным соответсвующим
            
            var single = products.Single(p => p.Energy == 10);

            var elementAt = products.ElementAt(5);

            #endregion
        }
    }
}