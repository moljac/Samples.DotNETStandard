using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsStudenttStatisticIndependent
    {
        public static double Skewness(IEnumerable<short> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static double Skewness(IEnumerable<ushort> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static double Skewness(IEnumerable<int> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static double Skewness(IEnumerable<uint> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static double Skewness(IEnumerable<long> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static double Skewness(IEnumerable<ulong> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static double Skewness(IEnumerable<float> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static double Skewness(IEnumerable<double> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double m3 = x.Moment(3);
            double sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (System.Math.Sqrt(n * n1) / n1) * m3 / System.Math.Pow(sx, 3);
        }

        public static decimal Skewness(IEnumerable<decimal> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            decimal m3 = x.Moment(3);
            decimal sx = x.StandardDeviation();
            int n = x.Count();
            int n1 = n - 1;

            return (decimal)(System.Math.Sqrt(n * n1) / n1) * m3 / (decimal)System.Math.Pow((double)sx, 3);
        }

    }
}
