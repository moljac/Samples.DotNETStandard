using System;
using System.Text;

#if NETSTANDARD1_0
using System.Net;

namespace HolisticWare.Net.HTTP
{
    public static partial class WebHeaderCollectionExtensionMethods
    {
        public static string ToString(this WebHeaderCollection collection)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var i in collection)
            {
                sb.AppendLine("");

            }

            return sb.ToString();
        }
    }
}
#endif