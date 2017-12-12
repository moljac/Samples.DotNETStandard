using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsVariancePopulation
    {
        public static double VariancePopulation(this IEnumerable<short> x)
        {
            double mean = x.Cast<int>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VariancePopulation(this IEnumerable<ushort> x)
        {
            double mean = x.Cast<int>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VariancePopulation(this IEnumerable<int> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VariancePopulation(this IEnumerable<uint> x)
        {
            double mean = x.Cast<long>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VariancePopulation(this IEnumerable<long> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VariancePopulation(this IEnumerable<ulong> x)
        {
            double mean = x.Cast<double>().Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VariancePopulation(this IEnumerable<float> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static double VariancePopulation(this IEnumerable<double> x)
        {
            double mean = x.Average();
            double sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                double delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

        public static decimal VariancePopulation(this IEnumerable<decimal> x)
        {
            decimal mean = x.Average();
            decimal sum_suquares = 0;

            long n = x.LongCount();

            for (int i = 0; i < n; i++)
            {
                decimal delta = x.ElementAt(i) - mean;

                sum_suquares += delta * delta;
            }

            return sum_suquares / n;
        }

    }
}
