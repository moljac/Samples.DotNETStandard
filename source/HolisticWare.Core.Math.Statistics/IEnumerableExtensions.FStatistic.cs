using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsFStatistic
    {
        public static double FStatistic(this IEnumerable<short> x, IEnumerable<short> y)
        {
            return x.Variance() / y.Variance();
        }

        public static double FStatistic(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            return x.Variance() / y.Variance();
        }

        public static double FStatistic(this IEnumerable<int> x, IEnumerable<int> y)
        {
            return x.Variance() / y.Variance();
        }

        public static double FStatistic(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            return x.Variance() / y.Variance();
        }

        public static double FStatistic(this IEnumerable<long> x, IEnumerable<long> y)
        {
            return x.Variance() / y.Variance();
        }

        public static double FStatistic(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            return x.Variance() / y.Variance();
        }

        public static double FStatistic(this IEnumerable<float> x, IEnumerable<float> y)
        {
            return x.Variance() / y.Variance();
        }

        public static double FStatistic(this IEnumerable<double> x, IEnumerable<double> y)
        {
            return x.Variance() / y.Variance();
        }

        public static decimal FStatistic(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            return x.Variance() / y.Variance();
        }
    }
}
