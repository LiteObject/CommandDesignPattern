using System;
using System.Diagnostics;

namespace CommandDesignPatternsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();


            watch.Stop();
            Console.WriteLine($"Press any key to exit. Elapsed: {watch.Elapsed}.");
            Console.Read();
        }
    }
}
