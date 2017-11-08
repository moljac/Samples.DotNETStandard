using System;
using System.Text;

#if ! NETSTANDARD1_0
using System.Net.Http;

namespace HolisticWare.Net.HTTP
{
    public static partial class HttpRequestMessageExtensionMethods
    {
        public static string ToString(this HttpRequestMessage request)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
    }
}
#endif