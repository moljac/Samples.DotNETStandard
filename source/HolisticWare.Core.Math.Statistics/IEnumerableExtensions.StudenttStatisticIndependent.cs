using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsStudenttStatisticIndependent
    {
        public static double StudenttStatisticIndependent(this IEnumerable<short> x, IEnumerable<short> y)
        {
            // equal variances
            double x_average = x.Cast<int>().Average();
            double y_average = y.Cast<int>().Average();
            double x_variance = x.VarianceSample();
            double y_variance = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = 
                System.Math.Sqrt
                        (
                            ((xn - 1) * x_variance + (yn - 1) * y_variance) 
                            / 
                            (xn + yn - 2)
                        );
            double denom = System.Math.Sqrt(x_variance / xn + y_variance / yn);

            return (x_average - y_average) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            // equal variances
            double x_average = x.Cast<int>().Average();
            double y_average = y.Cast<int>().Average();
            double x_variance = x.VarianceSample();
            double y_variance = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = 
                System.Math.Sqrt
                        (
                            ((xn - 1) * x_variance + (yn - 1) * y_variance) 
                            / 
                            (xn + yn - 2)
                        );
            double denom = System.Math.Sqrt(x_variance / xn + y_variance / yn);

            return (x_average - y_average) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<int> x, IEnumerable<int> y)
        {
            // equal variances
            double x_average = x.Average();
            double y_average = y.Average();
            double x_variance = x.VarianceSample();
            double y_variance = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = 
                System.Math.Sqrt
                        (
                            ((xn - 1) * x_variance + (yn - 1) * y_variance) 
                            / 
                            (xn + yn - 2)
                        );
            double denom = System.Math.Sqrt(x_variance / xn + y_variance / yn);

            return (x_average - y_average) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            // equal variances
            double x_average = x.Cast<long>().Average();
            double y_average = y.Cast<long>().Average();
            double x_variance = x.VarianceSample();
            double y_variance = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = 
                System.Math.Sqrt
                        (
                            ((xn - 1) * x_variance + (yn - 1) * y_variance) 
                            / 
                            (xn + yn - 2)
                        );
            double denom = System.Math.Sqrt(x_variance / xn + y_variance / yn);

            return (x_average - y_average) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<float> x, IEnumerable<float> y)
        {
            // equal variances
            double x_average = x.Average();
            double y_average = y.Average();
            double x_variance = x.VarianceSample();
            double y_variance = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = 
                System.Math.Sqrt
                        (
                            ((xn - 1) * x_variance + (yn - 1) * y_variance) 
                            / 
                            (xn + yn - 2)
                        );
            double denom = System.Math.Sqrt(x_variance / xn + y_variance / yn);

            return (x_average - y_average) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<double> x, IEnumerable<double> y)
        {
            // equal variances
            double x_average = x.Average();
            double y_average = y.Average();
            double x_variance = x.VarianceSample();
            double y_variance = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = 
                System.Math.Sqrt
                        (
                            ((xn - 1) * x_variance + (yn - 1) * y_variance) 
                            / 
                            (xn + yn - 2)
                        );
            double denom = System.Math.Sqrt(x_variance / xn + y_variance / yn);

            return (x_average - y_average) / denom;
        }

        public static decimal StudenttStatisticIndependent(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            // equal variances
            decimal x_average = x.Average();
            decimal y_average = y.Average();
            decimal x_variance = x.VarianceSample();
            decimal y_variance = y.VarianceSample();
            int xn = x.Count();
            int yn = y.Count();

            decimal sxy = 
                (decimal)System.Math.Sqrt
                                (
                                    (double)((xn - 1) * x_variance + (yn - 1) * y_variance) 
                                    / 
                                   (xn + yn - 2)
                                );
            decimal denom = (decimal)System.Math.Sqrt((double)(x_variance / xn + y_variance / yn));

            return (decimal)((x_average - y_average) / denom);
        }

    }
}
