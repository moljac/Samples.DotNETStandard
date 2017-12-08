using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    /// <summary>
    /// 
    /// </summary>
    public static class IEnumerableExtensionsMedian
    {
        public static double Median(this IEnumerable<short> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<ushort> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<int> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<uint> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<long> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<ulong> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<float> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static double Median(this IEnumerable<double> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5 * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

        public static decimal Median(this IEnumerable<decimal> x)
        {
            int n = x.Count();
            int n2 = n / 2 - 1;

            if (n % 2 == 1)
            {
                return x.ElementAt((n + 1) / 2 - 1);
            }

            return 0.5M * (x.ElementAt(n2) + x.ElementAt(n2 + 1));
        }

    }
}
