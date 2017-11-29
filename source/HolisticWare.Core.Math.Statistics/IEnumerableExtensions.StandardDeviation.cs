using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsStandardDeviation
    {
        public static double StandardDeviation(this IEnumerable<short> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static double StandardDeviation(this IEnumerable<ushort> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static double StandardDeviation(this IEnumerable<int> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static double StandardDeviation(this IEnumerable<uint> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static double StandardDeviation(this IEnumerable<long> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static double StandardDeviation(this IEnumerable<ulong> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static double StandardDeviation(this IEnumerable<float> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static double StandardDeviation(this IEnumerable<double> x)
        {
            return System.Math.Sqrt(x.Variance());
        }

        public static decimal StandardDeviation(this IEnumerable<decimal> x)
        {
            return (decimal) System.Math.Sqrt((double)x.Variance());
        }
    }
}
