using System;
using System.Text;

#if ! NETSTANDARD1_0
using System.Net.Http;

namespace Core.Net.HTTP
{
    public static partial class HttpResponseMessageExtensionMethods
    {
        public static string ToString(this HttpResponseMessage response)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
    }
}
#endif