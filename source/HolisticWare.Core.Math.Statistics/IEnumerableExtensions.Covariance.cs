using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsCovariance
    {
        public static double Covariance(this IEnumerable<short> x, IEnumerable<short> y)
        {
            long sumx = 0;
            long sumy = 0;
            long sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            long sumx = 0;
            long sumy = 0;
            long sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<int> x, IEnumerable<int> y)
        {
            long sumx = 0;
            long sumy = 0;
            long sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double sumx = 0;
            double sumy = 0;
            double sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double sumx = 0;
            double sumy = 0;
            double sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double sumx = 0;
            double sumy = 0;
            double sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double sumx = 0;
            double sumy = 0;
            double sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }

        public static decimal Covariance(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal sumx = 0;
            decimal sumy = 0;
            decimal sumxy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                sumx += x.ElementAt(i);
                sumy += y.ElementAt(i);
                sumxy += x.ElementAt(i) * y.ElementAt(i);
            }

            return (sumxy - sumx * sumy / n) / (n - 1);
        }
    }
}
