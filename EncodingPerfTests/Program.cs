using System;
using System.Diagnostics;

namespace EncodingPerfTests
{
    class Program
    {
        static void Main()
        {
            var timer = new Stopwatch();
            timer.Start();

            Console.WriteLine("GetByteCount Tests");
            Console.WriteLine();

            new UTF8.GetByteCount.With1KChar().Run();
            new UTF8.GetByteCount.With10KChar().Run();
            new UTF8.GetByteCount.With100KChar().Run();
            new UTF8.GetByteCount.With500KChar().Run();

            Console.WriteLine("GetBytes Tests");
            Console.WriteLine();

            new UTF8.GetBytes.With1KChar().Run();
            new UTF8.GetBytes.With10KChar().Run();
            new UTF8.GetBytes.With100KChar().Run();
            new UTF8.GetBytes.With500KChar().Run();

            timer.Stop();
            Console.WriteLine($"Total Execution Time: {timer.Elapsed}");

            Console.ReadLine();
        }
    }
}
