using System;
using System.IO;
using System.Threading.Tasks;

namespace LearnCSharp.Parallelism
{
    public class Async
    {
        public Async()
        {
            // DoWorkAsync(100);
            //
            // for (int i = 0; i < 100; i++)
            //     Console.WriteLine("DoWorkMainThread");

            var result = SaveFileAsync("test.txt");
            Console.WriteLine(result.Result);
        }

        public async Task<bool> SaveFileAsync(string path) =>
            await Task.Run(() => SaveFile(path));
        
        public bool SaveFile(string path)
        {
            var result = "";
            for (int i = 0; i < 10000; i++)
                result += new Random().Next(50);

            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(result);
            }

            return true;
        }
        
        public async Task DoWorkAsync(int max)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < max; i++)
                    Console.WriteLine("DoWork");
            });
            Console.WriteLine("DoWorkAsync");
        }
    }
}