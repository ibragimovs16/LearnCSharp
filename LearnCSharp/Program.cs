using System;
using LearnCSharp.AnonymousMethodsAndLambdaExpressions;
using LearnCSharp.AnonymousTypeAndTuple;
using LearnCSharp.AttributesAndReflection;
using LearnCSharp.DelegatesAndEvents;
using LearnCSharp.ExtensionMethod;
using LearnCSharp.IndexersAndIterators;
using LearnCSharp.LINQ;
using LearnCSharp.ObjectType;
using LearnCSharp.Parallelism;
using LearnCSharp.UnsafeCode;

namespace LearnCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // _ = new DelegatesAndEventsEntryPoint();
            // _ = new ParallelismEntryPoint();
            // _ = new LinqEntryPoint();
            // _ = new ExtensionMethodEntryPoint();
            // _ = new IndexersAndIteratorsEntryPoint();
            // _ = new AnonymousTypeAndTupleEntryPoint();
            // _ = new AnonymousMethodsAndLambdaExpressionsEntryPoint();
            // _ = new AttributesAndReflectionEntryPoint();
            // _ = new ObjectTypeEntryPoint();
            _ = new UnsafeCodeEntryPoint();
        
            Console.ReadKey();
        }
    }
}
