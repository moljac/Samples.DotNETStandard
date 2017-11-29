using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsKurtosisPop
    {
        public static double KurtosisPop(this IEnumerable<short> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisPop(this IEnumerable<ushort> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisPop(this IEnumerable<int> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisPop(this IEnumerable<uint> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisPop(this IEnumerable<long> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisPop(this IEnumerable<ulong> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisPop(this IEnumerable<float> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static double KurtosisPop(this IEnumerable<double> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }

        public static decimal KurtosisPop(this IEnumerable<decimal> x)
        {
            int n = x.Count();

            if (n >= 3)
            {
                return (n - 1) * ((n + 1) * x.Kurtosis() + 6) / ((n - 2) * (n - 3));
            }

            return 0;
        }
    }
}
