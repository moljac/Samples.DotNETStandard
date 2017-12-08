using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    /// <summary>
    /// Kurtosis
    /// Sharpness of the peak of a frequency-distribution curve.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Kurtosis"/>
    /// <see cref="http://www.itl.nist.gov/div898/handbook/eda/section3/eda35b.htm"/>
    public static class IEnumerableExtensionsKurtosisExcess
    {
        public static double KurtosisExcess(this IEnumerable<short> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess(this IEnumerable<ushort> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess(this IEnumerable<int> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess(this IEnumerable<uint> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess(this IEnumerable<long> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess(this IEnumerable<ulong> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess(this IEnumerable<float> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static double KurtosisExcess(this IEnumerable<double> x)
        {
            return x.Kurtosis() - 3.0;
        }

        public static decimal KurtosisExcess(this IEnumerable<decimal> x)
        {
            return x.Kurtosis() - 3.0M;
        }

    }
}
