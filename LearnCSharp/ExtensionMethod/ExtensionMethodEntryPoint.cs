using System;

namespace LearnCSharp.ExtensionMethod
{
    public class ExtensionMethodEntryPoint
    {
        public ExtensionMethodEntryPoint()
        {
            var x = 5;
            Console.WriteLine(x.IsEven());
            Console.WriteLine(x.IsDividedBy(5));
        }
    }
}