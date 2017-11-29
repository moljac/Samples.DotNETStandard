using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsCorrelation
    {
        public static double Correlation(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double sx = x.StandardDeviation();
            double sy = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Cast<int>().Average() * y.Cast<int>().Average()) / ((n - 1) * sx * sy);
        }

        public static double Correlation(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double sx = x.StandardDeviation();
            double sy = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Cast<int>().Average() * y.Cast<int>().Average()) / ((n - 1) * sx * sy);
        }

        public static double Correlation(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double sx = x.StandardDeviation();
            double sy = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Average() * y.Average()) / ((n - 1) * sx * sy);
        }

        public static double Correlation(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double sx = x.StandardDeviation();
            double sy = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Cast<long>().Average() * y.Cast<long>().Average()) / ((n - 1) * sx * sy);
        }

        public static double Correlation(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double sx = x.StandardDeviation();
            double sy = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Average() * y.Average()) / ((n - 1) * sx * sy);
        }

        public static double Correlation(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double sx = x.StandardDeviation();
            double sy = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Cast<double>().Average() * y.Cast<double>().Average()) / ((n - 1) * sx * sy);
        }

        public static double Correlation(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double sx = x.StandardDeviation();
            double sy = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Average() * y.Average()) / ((n - 1) * sx * sy);
        }

        public static decimal Correlation(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal sx = x.StandardDeviation();
            decimal sy = y.StandardDeviation();

            decimal sum = 0.0M;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sum - n * x.Average() * y.Average()) / ((n - 1) * sx * sy);
        }
    }
}
