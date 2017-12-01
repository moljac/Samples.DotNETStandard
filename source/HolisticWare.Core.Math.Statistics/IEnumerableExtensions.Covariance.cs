using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsCovariance
    {
        public static double Covariance(this IEnumerable<short> x, IEnumerable<short> y)
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                short y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                ushort y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<int> x, IEnumerable<int> y)
        {
            long sum_x = 0;
            long sum_y = 0;
            long sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                int y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<long> x, IEnumerable<long> y)
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                long y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                ulong y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<float> x, IEnumerable<float> y)
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                float y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static double Covariance(this IEnumerable<double> x, IEnumerable<double> y)
        {
            double sum_x = 0;
            double sum_y = 0;
            double sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                double y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }

        public static decimal Covariance(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            decimal sum_x = 0;
            decimal sum_y = 0;
            decimal sum_product_xy = 0;

            int n = x.Count();

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                decimal y_i = y.ElementAt(i);
                sum_x += x_i;
                sum_y += y_i;
                sum_product_xy += x_i * y_i;
            }

            return (sum_product_xy - sum_x * sum_y / n) / (n - 1);
        }
    }
}
