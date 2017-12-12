using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    /// <summary>
    /// F-Statistics / F test
    /// A value you get when you run an ANOVA test or a regression analysis to 
    /// find out if the means between two populations are significantly 
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/F-test"/>
    public static class IEnumerableExtensionsFStatistic
    {
        public static double FStatistic(this IEnumerable<short> x, IEnumerable<short> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic(this IEnumerable<int> x, IEnumerable<int> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic(this IEnumerable<long> x, IEnumerable<long> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic(this IEnumerable<float> x, IEnumerable<float> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static double FStatistic(this IEnumerable<double> x, IEnumerable<double> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }

        public static decimal FStatistic(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            return x.VarianceSample() / y.VarianceSample();
        }
    }
}
