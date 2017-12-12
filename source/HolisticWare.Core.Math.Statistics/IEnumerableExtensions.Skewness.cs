using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsSkewness
    {
        public static double Skewness(IEnumerable<short> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double Skewness(IEnumerable<ushort> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double Skewness(IEnumerable<int> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double Skewness(IEnumerable<uint> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double Skewness(IEnumerable<long> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / System.Math.Pow(x_standard_deviation, 3)
                        ;
        }

        public static double Skewness(IEnumerable<ulong> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double Skewness(IEnumerable<float> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static double Skewness(IEnumerable<double> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            double x_moment_3 = x.Moment(3);
            double x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return 
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                System.Math.Pow(x_standard_deviation, 3)
                      ;
        }

        public static decimal Skewness(IEnumerable<decimal> x)
        {
            // NIST definition of adjusted Fisher-Pearson
            // coefficient of skewness
            decimal x_moment_3 = x.Moment(3);
            decimal x_standard_deviation = x.StandardDeviationSample();
            int n = x.Count();
            int n1 = n - 1;

            return (decimal)
                (System.Math.Sqrt(n * n1) / n1) * x_moment_3 
                / 
                (decimal)System.Math.Pow((double)x_standard_deviation, 3)
                               ;
        }

    }
}
