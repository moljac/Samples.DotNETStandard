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
            double xmean = x.Cast<int>().Average();
            double ymean = y.Cast<int>().Average();
            double xvar = x.Variance();
            double yvar = y.Variance();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = System.Math.Sqrt(((xn - 1) * xvar + (yn - 1) * yvar) / (xn + yn - 2));
            double denom = System.Math.Sqrt(xvar / xn + yvar / yn);

            return (xmean - ymean) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            // equal variances
            double xmean = x.Cast<int>().Average();
            double ymean = y.Cast<int>().Average();
            double xvar = x.Variance();
            double yvar = y.Variance();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = System.Math.Sqrt(((xn - 1) * xvar + (yn - 1) * yvar) / (xn + yn - 2));
            double denom = System.Math.Sqrt(xvar / xn + yvar / yn);

            return (xmean - ymean) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<int> x, IEnumerable<int> y)
        {
            // equal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.Variance();
            double yvar = y.Variance();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = System.Math.Sqrt(((xn - 1) * xvar + (yn - 1) * yvar) / (xn + yn - 2));
            double denom = System.Math.Sqrt(xvar / xn + yvar / yn);

            return (xmean - ymean) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            // equal variances
            double xmean = x.Cast<long>().Average();
            double ymean = y.Cast<long>().Average();
            double xvar = x.Variance();
            double yvar = y.Variance();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = System.Math.Sqrt(((xn - 1) * xvar + (yn - 1) * yvar) / (xn + yn - 2));
            double denom = System.Math.Sqrt(xvar / xn + yvar / yn);

            return (xmean - ymean) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<float> x, IEnumerable<float> y)
        {
            // equal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.Variance();
            double yvar = y.Variance();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = System.Math.Sqrt(((xn - 1) * xvar + (yn - 1) * yvar) / (xn + yn - 2));
            double denom = System.Math.Sqrt(xvar / xn + yvar / yn);

            return (xmean - ymean) / denom;
        }

        public static double StudenttStatisticIndependent(this IEnumerable<double> x, IEnumerable<double> y)
        {
            // equal variances
            double xmean = x.Average();
            double ymean = y.Average();
            double xvar = x.Variance();
            double yvar = y.Variance();
            int xn = x.Count();
            int yn = y.Count();

            double sxy = System.Math.Sqrt(((xn - 1) * xvar + (yn - 1) * yvar) / (xn + yn - 2));
            double denom = System.Math.Sqrt(xvar / xn + yvar / yn);

            return (xmean - ymean) / denom;
        }

        public static decimal StudenttStatisticIndependent(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            // equal variances
            decimal xmean = x.Average();
            decimal ymean = y.Average();
            decimal xvar = x.Variance();
            decimal yvar = y.Variance();
            int xn = x.Count();
            int yn = y.Count();

            decimal sxy = (decimal)System.Math.Sqrt((double)((xn - 1) * xvar + (yn - 1) * yvar) / (xn + yn - 2));
            decimal denom = (decimal)System.Math.Sqrt((double)(xvar / xn + yvar / yn));

            return (decimal)((xmean - ymean) / denom);
        }

    }
}
