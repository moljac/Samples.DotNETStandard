using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsStandardDeviationPopulation
    {
        public static double StandardDeviationPopulation(this IEnumerable<short> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation(this IEnumerable<ushort> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation(this IEnumerable<int> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation(this IEnumerable<uint> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation(this IEnumerable<long> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation(this IEnumerable<ulong> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation(this IEnumerable<float> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static double StandardDeviationPopulation(this IEnumerable<double> x)
        {
            return System.Math.Sqrt(x.VariancePopulation());
        }

        public static decimal StandardDeviationPopulation(this IEnumerable<decimal> x)
        {
            return (decimal) System.Math.Sqrt((double)x.VariancePopulation());
        }
    }
}
