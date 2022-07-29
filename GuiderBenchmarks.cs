using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfficientCsharp
{

    [MemoryDiagnoser(false)]
    public class GuiderBenchmarks
    {
        private static readonly Guid TestIdAsGuid = Guid.Parse("7a8b06fa-e8d0-4bc4-a733-eabd77a254b4");
        private const string TestIdAsString = "uqx4nn6s-Uu4Qzm99QtWmg";


        [Benchmark]
        public Guid ToGuidFromString()
        {
            return Guider.ToGuidFromString(TestIdAsString);
        }

        [Benchmark]
        public Guid ToGuidFromStringOp()
        {
            return Guider.ToGuidFromStringOp(TestIdAsString);
        }

        [Benchmark]
        public string ToStringFromGuid()
        {
            return Guider.ToStringFromGuid(TestIdAsGuid);
        }

        [Benchmark]
        public string ToStringFromGuidOp()
        {
            return Guider.ToStringFromGuidOp(TestIdAsGuid);
        }

    }
}
