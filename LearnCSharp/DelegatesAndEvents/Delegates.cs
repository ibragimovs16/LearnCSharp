using System;

namespace LearnCSharp.DelegatesAndEvents
{
    public class Delegates
    {
        // модификатор_доступа delegate тип_возвращаемого_значения название(принимаемые_аргументы);
        // Action - ничего не возвращает, может принимать аргументы
        // Predicate - имеет тип возвращаемого значения bool, может принимать аргументы
        // Func - имеет указываемый тип возвращаемого значения, может принимать аргументы

        public delegate void MyDelegate();
        public delegate int ValueDelegate(int i);

        public Action actionDelegate;
        public Action<int> actionDelegateWithArg;

        // public delegate bool Predicate(int value);
        public Predicate<int> predicate;

        // public delegate int func(); 
        public Func<int> func;
        // public delegate string funcWithArg(int value);
        public Func<int, int> funcWithArg; // Последний аргумент - тип возвращаемого значения делегата.

        public Delegates()
        {
            MyDelegate myDelegate = Method1;
            myDelegate += Method4;
            myDelegate();

            Console.WriteLine();

            MyDelegate myDelegate1 = new MyDelegate(Method4);
            myDelegate1 += Method4;
            myDelegate1?.Invoke();

            Console.WriteLine();

            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            myDelegate2.Invoke();

            Console.WriteLine();

            ValueDelegate valueDelegate = MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate += MethodValue;
            valueDelegate?.Invoke(new Random().Next(10));

            Console.WriteLine();

            actionDelegate = Method1;
            actionDelegate?.Invoke();

            Console.WriteLine();

            actionDelegateWithArg = Method3;
            actionDelegateWithArg?.Invoke(new Random().Next(10));
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }

        public void Method3(int i)
        {
            Console.WriteLine("Method3");
        }

        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}
