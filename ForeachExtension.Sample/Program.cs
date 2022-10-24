using BenchmarkDotNet.Running;
using System;

namespace ForeachExtension.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}
