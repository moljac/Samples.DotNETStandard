using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Statistics
{
    public static class IEnumerableExtensionsKurtosis
    {
        public static double Kurtosis(this IEnumerable<short> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double Kurtosis(this IEnumerable<ushort> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double Kurtosis(this IEnumerable<int> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double Kurtosis(this IEnumerable<uint> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double Kurtosis(this IEnumerable<long> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double Kurtosis(this IEnumerable<ulong> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double Kurtosis(this IEnumerable<float> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static double Kurtosis(this IEnumerable<double> x)
        {
            double m2 = x.Moment(2);
            double m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0;
        }

        public static decimal Kurtosis(this IEnumerable<decimal> x)
        {
            decimal m2 = x.Moment(2);
            decimal m4 = x.Moment(4);

            return m4 / (m2 * m2) - 3.0m;
        }

    }
}
