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
    /// <see cref="http://www.mathsisfun.com/data/correlation.html"/>
    public static class IEnumerableExtensionsFrequency
    {
        public static Dictionary<T, uint> Frequency<T>(this IEnumerable<T> x)
        {
            long n = x.LongCount();

            Dictionary<T, uint> frequencies = new Dictionary<T, uint>((int) n);

            for (int i = 0; i < n; i++)
            {
                T x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<ushort, uint> Frequency(this IEnumerable<ushort> x)
        {
            long n = x.LongCount();

            Dictionary<ushort, uint> frequencies = new Dictionary<ushort, uint>((int) n);

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }                
            }

            return frequencies;
        }

        public static Dictionary<short, uint> Frequency(this IEnumerable<short> x)
        {
            long n = x.LongCount();

            Dictionary<short, uint> frequencies = new Dictionary<short, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<int, uint> Frequency(this IEnumerable<int> x)
        {
            long n = x.LongCount();

            Dictionary<int, uint> frequencies = new Dictionary<int, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<uint, uint> Frequency(this IEnumerable<uint> x)
        {
            long n = x.LongCount();

            Dictionary<uint, uint> frequencies = new Dictionary<uint, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<long, uint> Frequency(this IEnumerable<long> x)
        {
            long n = x.LongCount();

            Dictionary<long, uint> frequencies = new Dictionary<long, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<ulong, uint> Frequency(this IEnumerable<ulong> x)
        {
            long n = x.LongCount();

            Dictionary<ulong, uint> frequencies = new Dictionary<ulong, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<float, uint> Frequency(this IEnumerable<float> x)
        {
            long n = x.LongCount();

            Dictionary<float, uint> frequencies = new Dictionary<float, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<double, uint> Frequency(this IEnumerable<double> x)
        {
            long n = x.LongCount();

            Dictionary<double, uint> frequencies = new Dictionary<double, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }

        public static Dictionary<decimal, uint> Frequency(this IEnumerable<decimal> x)
        {
            long n = x.LongCount();

            Dictionary<decimal, uint> frequencies = new Dictionary<decimal, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            return frequencies;
        }
    }
}
