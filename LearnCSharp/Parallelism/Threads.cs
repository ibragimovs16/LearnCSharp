using System;
using System.Threading;

namespace LearnCSharp.Parallelism
{
    public class Threads
    {
        public Threads()
        {
            Thread thread = new Thread(DoWork);
            thread.Start();

            Thread thread1 = new Thread(DoWork1);
            thread1.Start(int.MaxValue);
            
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                
                if (i % 10000 == 0) Console.WriteLine("DoWorkMainThread");
            }
        }

        public void DoWork()
        {
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                
                if (i % 10000 == 0) Console.WriteLine("DoWork");
            }
        }
        
        public void DoWork1(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                
                if (i % 10000 == 0) Console.WriteLine("DoWork2");
            }
        }
    }
}