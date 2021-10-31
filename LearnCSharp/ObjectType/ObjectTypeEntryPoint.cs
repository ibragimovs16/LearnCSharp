using System;

namespace LearnCSharp.ObjectType
{
    public class ObjectTypeEntryPoint
    {
        public ObjectTypeEntryPoint()
        {
            var obj = new object();

            int i = 5;
            int j = 5;

            Console.WriteLine(i.Equals(j)); // true, сравнение значений

            var p1 = new Point {X = 5};
            var p2 = new Point {X = 5};

            Console.WriteLine(p1.Equals(p2)); // false, сравнение адресса в памяти 
            Console.WriteLine(p1.GetHashCode() + " " + p2.GetHashCode());

            var op1 = new OverridePoint {X = 5};
            var op2 = new OverridePoint {X = 5};

            Console.WriteLine(op1.Equals(op2));
            Console.WriteLine(op1.GetHashCode() + " " + op2.GetHashCode());

            Console.WriteLine(p1.GetType());
            Console.WriteLine(op1.GetType());

            Console.WriteLine(typeof(Point));
            Console.WriteLine(p1.GetType() == typeof(Point)); // or: p1 is Point

            var op3 = op1.Clone();
            op3.X = 10;

            Console.WriteLine(op1.X);
            Console.WriteLine(op3.X);
        }
    }
}