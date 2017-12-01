using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    public static class IEnumerableExtensionsCorrelation
    {
        public static double Correlation(this IEnumerable<short> x, IEnumerable<short> y)
        {
            double standard_deviation_x = x.StandardDeviation();
            double standard_deviation_y = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Cast<int>().Average() * y.Cast<int>().Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            double standard_deviation_x = x.StandardDeviation();
            double standard_deviation_y = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Cast<int>().Average() * y.Cast<int>().Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<int> x, IEnumerable<int> y)
        {
            double standard_deviation_x = x.StandardDeviation();
            double standard_deviation_y = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Average() * y.Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            double standard_deviation_x = x.StandardDeviation();
            double standard_deviation_y = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Cast<long>().Average() * y.Cast<long>().Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double standard_deviation_x = x.StandardDeviation();
            double standard_deviation_y = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Average() * y.Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double standard_deviation_x = x.StandardDeviation();
            double standard_deviation_y = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Cast<double>().Average() * y.Cast<double>().Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }

        public static double Correlation(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double standard_deviation_x = x.StandardDeviation();
            double standard_deviation_y = y.StandardDeviation();

            double sum = 0.0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Average() * y.Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;            
        }

        public static decimal Correlation(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal standard_deviation_x = x.StandardDeviation();
            decimal standard_deviation_y = y.StandardDeviation();

            decimal sum = 0.0M;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sum += x.ElementAt(i) * y.ElementAt(i);
            }

            return 
                (sum - n * x.Average() * y.Average()) 
                / 
                ((n - 1) * standard_deviation_x * standard_deviation_y)
                ;
        }
    }
}
