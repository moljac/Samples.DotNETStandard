using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsMoment
    {
        public static double Moment(this IEnumerable<short> x, int m)
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

        public static double Moment(this IEnumerable<ushort> x, int m)
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

        public static double Moment(this IEnumerable<int> x, int m)
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

        public static double Moment(this IEnumerable<uint> x, int m)
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

        public static double Moment(this IEnumerable<long> x, int m)
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

        public static double Moment(this IEnumerable<ulong> x, int m)
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

        public static double Moment(this IEnumerable<float> x, int m)
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

        public static double Moment(this IEnumerable<double> x, int m)
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

        public static decimal Moment(this IEnumerable<decimal> x, int m)
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
