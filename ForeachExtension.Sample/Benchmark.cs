using BenchmarkDotNet.Attributes;

namespace ForeachExtension.Sample
{
    [MemoryDiagnoser(false)]
    public class Benchmark
    {
        [Params(10, 100, 1000, 10000, 100000)]
        public int Size { get; set; }

        [Benchmark]
        public void NormalForLoop()
        {
            for (int i = 0; i < this.Size; i++)
            {
                this.DoSomething();
            }
        }

        [Benchmark]
        public void ExtensionForLoop()
        {
            foreach (var i in 0..this.Size)
            {
                this.DoSomething();
            }
        }

        private void DoSomething()
        {
            // Do Nothing
        }
    }
}
