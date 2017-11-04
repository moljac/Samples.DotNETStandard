using System;
using System.Text;

#if NETSTANDARD1_0
using System.Net;

namespace HolisticWare.Net.HTTP
{
    public static partial class HttpWebRequestExtensionMethods
    {
        public static string ToString(this HttpWebRequest request)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
    }
}
#endif