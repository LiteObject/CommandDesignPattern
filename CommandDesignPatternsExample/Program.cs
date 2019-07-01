namespace CommandDesignPatternsExample
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// The program. Command decouples the object that invokes the operation from the one that knows how to perform it. 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();

            var orderActionExec = new OrderActionExecutor();
            var order = new Order();
            
            watch.Stop();
            Console.WriteLine($"Press any key to exit. Elapsed: {watch.Elapsed}.");
            Console.Read();
        }
    }
}
