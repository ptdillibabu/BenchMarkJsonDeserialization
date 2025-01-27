using BenchmarkDotNet.Running;
using System;
namespace BenchMarking
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<JsonDeserializationBenchmarks>();
            Console.WriteLine(summary.Reports);
        }
    }
}
