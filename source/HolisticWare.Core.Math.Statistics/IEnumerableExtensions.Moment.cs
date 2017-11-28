using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsMoment
    {
        public static double Median(this IEnumerable<short> x, int m)
        {
            double mean = x.Cast<int>().Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static double Median(this IEnumerable<ushort> x, int m)
        {
            double mean = x.Cast<int>().Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static double Median(this IEnumerable<int> x, int m)
        {
            double mean = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static double Median(this IEnumerable<uint> x, int m)
        {
            double mean = x.Cast<long>().Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static double Median(this IEnumerable<long> x, int m)
        {
            double mean = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static double Median(this IEnumerable<ulong> x, int m)
        {
            double mean = x.Cast<double>().Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static double Median(this IEnumerable<float> x, int m)
        {
            double mean = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static double Median(this IEnumerable<double> x, int m)
        {
            double mean = x.Average();
            double sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += System.Math.Pow(x.ElementAt(i) - mean, m);
            }

            return sum / n;
        }

        public static decimal Median(this IEnumerable<decimal> x, int m)
        {
            decimal mean = x.Average();
            decimal sum = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += (decimal)System.Math.Pow((double)x.ElementAt(i) - (double)mean, m);
            }

            return sum / n;
        }
    }
}
