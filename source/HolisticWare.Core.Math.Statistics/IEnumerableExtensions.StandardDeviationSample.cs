using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsStandardDeviationSample
    {
        public static double StandardDeviationSample(this IEnumerable<short> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample(this IEnumerable<ushort> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample(this IEnumerable<int> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample(this IEnumerable<uint> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample(this IEnumerable<long> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample(this IEnumerable<ulong> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample(this IEnumerable<float> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static double StandardDeviationSample(this IEnumerable<double> x)
        {
            return System.Math.Sqrt(x.VarianceSample());
        }

        public static decimal StandardDeviationSample(this IEnumerable<decimal> x)
        {
            return (decimal) System.Math.Sqrt((double)x.VarianceSample());
        }
    }
}
