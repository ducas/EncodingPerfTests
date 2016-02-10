using System;
using System.Diagnostics;

namespace EncodingPerfTests
{
    internal abstract class BaseTest
    {
        public void Run()
        {
            Console.WriteLine($"Test: {Name}");
            Console.WriteLine($"Iterations: {Iterations}");
            var timer = new Stopwatch();
            timer.Start();
            for (var i = 0; i < Iterations; i++)
            {
                OnRun();
            }
            timer.Stop();
            Console.WriteLine($"Execution Time: {timer.Elapsed}");
            Console.WriteLine($"Avg Time/Iteration (ms): {timer.ElapsedMilliseconds / (double)Iterations}");
            Console.WriteLine();
        }

        protected abstract void OnRun();
        protected abstract string Name { get; }
        protected abstract int Iterations { get; }
    }
}