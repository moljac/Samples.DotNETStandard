using System;
using System.Collections.Generic;
using System.Text;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
    {
        public override string ToString()
        {
            return this.ToString("R", System.Globalization.CultureInfo.CurrentCulture);
        }


        public string ToString(string format)
        {
            string[] formats = format.Split
                                        (
                                             new char[] { ' ', ';', ',' },
                                            StringSplitOptions.RemoveEmptyEntries
                                        );

            StringBuilder sb = new StringBuilder();

            foreach (string f in formats)
            {
                sb.AppendLine("---------------------------------------------------------------------");
                sb.AppendLine($"Format = {f}");
                sb.AppendLine($"{this.ToString(f, System.Globalization.CultureInfo.CurrentCulture)}");
                sb.AppendLine();
                sb.AppendLine("---------------------------------------------------------------------");
            }

            return sb.ToString();
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "R";

            if (provider == null)
            {
                provider = System.Globalization.CultureInfo.CurrentCulture;
            }

            string retval = null;

            switch (format.ToUpperInvariant())
            {
                case "A":
                case "ABSTRACTION":
                    retval = this.ToStringAbstractionAPI();
                    break;
                case "I":
                case "IMPLEMENTATION":
                    retval = this.ToStringImplementationObject();
                    break;
                case "R":
                case "RAW":
                    retval = this.ToStringRaw();
                    break;
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }

            return retval;
        }

        public string ToStringAbstractionAPI()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Abstraction API {this.GetType().ToString()}");

            foreach (Uri uri in this.EndPoints)
            {
                sb.AppendLine($"uri.OriginalString = {uri.OriginalString}");
                sb.AppendLine($"uri.AbsoluteUri    = {uri.AbsoluteUri}");
                sb.AppendLine($"uri.AbsolutePath   = {uri.AbsolutePath}");
                sb.AppendLine($"uri.Host           = {uri.Host}");
                sb.AppendLine($"Uri.PathAndQuery   = {uri.PathAndQuery}");

                sb.AppendLine();
                sb.Append(this.RequestMethodVerb).Append(" ").Append(uri.PathAndQuery).AppendLine("HTTP/v.v");

                //foreach (KeyValuePair<string, string> dp in )
                //{
                //    sb.Append(hdr.Key).Append(": ").AppendLine(hdr.Value);
                //}

                return sb.ToString();
            }

            foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
            {
                sb.Append(hdr.Key).Append(": ").AppendLine(hdr.Value);
            }
            sb.AppendLine($"DataAsString       = {this.DataAsString}");
            sb.AppendLine($"ParametersAsString = {this.ParametersAsString}");
            foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
            {
            }

            return sb.ToString();
        }

    }
}
