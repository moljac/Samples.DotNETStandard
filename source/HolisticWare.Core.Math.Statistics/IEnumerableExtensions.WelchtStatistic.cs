using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    /// <summary>
    /// Welch t test (statistics)
    /// </summary>
    /// TODO: Welch t test (statistics) 1. optimize/reduce redundant code (analysis needed)
    /// TODO: Welch t test (statistics) 2. async/await
    public static class IEnumerableExtensionsWelchtStatistic
    {
        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<short> x,
                                                                            IEnumerable<short> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Cast<int>().Average();
            double ymean = y.Cast<int>().Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<int> x,
                                                                            IEnumerable<int> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<uint> x,
                                                                            IEnumerable<uint> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Cast<long>().Average();
            double ymean = y.Cast<long>().Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<long> x,
                                                                            IEnumerable<long> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<ulong> x,
                                                                            IEnumerable<ulong> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Cast<double>().Average();
            double ymean = y.Cast<double>().Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<float> x,
                                                                            IEnumerable<float> y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (double welch_t, double degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<double> x, 
                                                                            IEnumerable<double>  y
                                                                        )
        {
            // unequal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.VarianceSample();
            double yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            double xvn = xvar / xn;
            double yvn = yvar / yn;
            double sxy = System.Math.Sqrt(xvn + yvn);

            double df = System.Math.Pow(xvn + yvn, 2) / (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1));
            double ws = (xmean - ymean) / sxy;

            return (ws, df);
        }

        public static (decimal welch_t, decimal degrees_of_freedom) WelchtStatistic
                                                                        (
                                                                            this IEnumerable<decimal> x,
                                                                            IEnumerable<decimal> y
                                                                        )
        {
            // unequal variances
            decimal xmean = x.Average();
            decimal ymean = y.Average();
            decimal xvar = x.VarianceSample();
            decimal yvar = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();
            decimal xvn = xvar / xn;
            decimal yvn = yvar / yn;
            decimal sxy = (decimal) System.Math.Sqrt((double)(xvn + yvn));

            decimal df = 
                            (decimal) System.Math.Pow((double)(xvn + yvn), 2)
                            / 
                            (xvn * xvn / (xn - 1) + yvn * yvn / (yn - 1))
                            ;
            decimal ws = (xmean - ymean) / sxy;

            return (ws, df);
        }
    }
}
