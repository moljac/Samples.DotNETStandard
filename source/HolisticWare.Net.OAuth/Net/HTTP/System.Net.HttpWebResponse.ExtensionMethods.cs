using System;
using System.Text;

#if NETSTANDARD1_0
using System.Net;

namespace HolisticWare.Net.HTTP
{
    public static partial class HttpWebResponseExtensionMethods
    {
        public static string ToString(this HttpWebResponse response)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
    }
}
#endif