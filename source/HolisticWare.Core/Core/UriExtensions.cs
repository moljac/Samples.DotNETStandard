using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class UriExtensions
    {
        public static string ToString(this Uri uri, string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                return uri.ToString();
            }

            return uri.ToString(format, System.Globalization.CultureInfo.CurrentCulture);
        }        

        public static string ToString(this Uri uri, string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format))
            {
                return uri.ToString();
            }

            if (provider == null)
            {
                provider = System.Globalization.CultureInfo.CurrentCulture;
            }

            string[] formats = format.Split
                                        (
                                             new char[] { ' ', ';', ',' },
                                            StringSplitOptions.RemoveEmptyEntries
                                        );

            StringBuilder sb = new StringBuilder();

            switch (format.ToUpperInvariant())
            {
                case "D":
                case "DEBUG":
                    sb.AppendLine($"uri.OriginalString = {uri.OriginalString}");
                    sb.AppendLine($"uri.AbsoluteUri    = {uri.AbsoluteUri}");
                    sb.AppendLine($"uri.AbsolutePath   = {uri.AbsolutePath}");
                    sb.AppendLine($"uri.Host           = {uri.Host}");
                    sb.AppendLine($"Uri.PathAndQuery   = {uri.PathAndQuery}");
                    break;
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }

            return sb.ToString();
        }
    }
}
