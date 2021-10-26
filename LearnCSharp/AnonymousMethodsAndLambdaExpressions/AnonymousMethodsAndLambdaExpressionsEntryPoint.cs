using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnCSharp.AnonymousMethodsAndLambdaExpressions
{
    public class AnonymousMethodsAndLambdaExpressionsEntryPoint
    {
        public delegate int MyHandler(int i);
        
        public AnonymousMethodsAndLambdaExpressionsEntryPoint()
        {
            // Анонимный метод
            MyHandler handler = delegate(int i) { return i * i; };

            Console.WriteLine(handler?.Invoke(5));
            
            // Лямбда-выражение
            handler += i => i * i;
            
            Console.WriteLine(handler?.Invoke(5));

            Console.WriteLine();

            var lesson = new Lesson("title...");
            lesson.Started += (sender, e) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(e);
            };
            
            lesson.Start();

            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            
            var res = list.Aggregate((x, y) => x + y);

            Console.WriteLine(res);

            var result1 = Agr(list, x => x * x * x);

            Console.WriteLine(result1);
        }

        public static int Agr(List<int> list, MyHandler handler)
        {
            int result = 0;

            foreach (var item in list)
            {
                result += handler.Invoke(item);
            }

            return result;
        }
    }
}