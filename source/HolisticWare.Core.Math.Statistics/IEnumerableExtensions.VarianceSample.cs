using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsVarianceSample
    {
        public static double VarianceSample(this IEnumerable<short> x)
        {
            double mean = x.Cast<int>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample(this IEnumerable<ushort> x)
        {
            double mean = x.Cast<int>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample(this IEnumerable<int> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample(this IEnumerable<uint> x)
        {
            double mean = x.Cast<long>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample(this IEnumerable<long> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample(this IEnumerable<ulong> x)
        {
            double mean = x.Cast<double>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample(this IEnumerable<float> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static double VarianceSample(this IEnumerable<double> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

        public static decimal VarianceSample(this IEnumerable<decimal> x)
        {
            decimal mean = x.Average();
            decimal sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                decimal delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / (n - 1);
        }

    }
}
