using System;

namespace LearnCSharp.UnsafeCode
{
    public class UnsafeCodeEntryPoint
    {
        public UnsafeCodeEntryPoint()
        {
            unsafe
            {
                int i = 30;
                int* ptrI = &i;
                Console.WriteLine(*ptrI); // value
                Console.WriteLine((long) ptrI); // address

                int a = 5;
                int b = 7;

                Calc(a, &b);

                Console.WriteLine(a + " " + b);

                var newPtr = ptrI + 4;
                Console.WriteLine(*newPtr);

                var ptrOnPtrOnI = &ptrI;
                Console.WriteLine(**ptrOnPtrOnI);
                Console.WriteLine((long)*ptrOnPtrOnI);
                Console.WriteLine((long)ptrOnPtrOnI);
            }
        }

        public unsafe void Calc(int i, int* j)
        {
            i = 500;
            *j = 700;

        }

        public void Calc(int i, ref int j)
        {
        }
    }
}