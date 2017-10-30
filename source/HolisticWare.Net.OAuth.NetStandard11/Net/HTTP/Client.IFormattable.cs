using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using System.Net;
using System.Text;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IFormattable
    {
        public override string ToString()
        {
            return this.ToString("R", System.Globalization.CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, System.Globalization.CultureInfo.CurrentCulture);
        }

        public string ToStringRaw()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Uri uri in this.EndPoints)
            {
                sb.Append(this.RequestMethodVerb).Append(" ").Append(uri.PathAndQuery).AppendLine("HTTP/v.v");
                foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
                {
                    sb.Append(hdr.Key).Append(": ").AppendLine(hdr.Value);
                }

            }

            return sb.ToString();
        }

        public string ToStringClient()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Uri uri in this.EndPoints)
            {
                sb.Append(this.RequestMethodVerb).Append(" ").Append(uri.PathAndQuery).AppendLine("HTTP/v.v");
                foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
                {
                    sb.Append(hdr.Key).Append(": ").AppendLine(hdr.Value);
                }

            }

            return sb.ToString();
        }

        public string ToStringImplementationObject()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Uri uri in this.EndPoints)
            {
                sb.AppendLine($"----------------------------------------------------------------------------");
                //sb.AppendLine($"[Method] = {http_web_request.Method}");
                //sb.AppendLine($"[Method] = {http_web_request.Method}");
                //sb.AppendLine($"[RequestUri] = {http_web_request.RequestUri}");
                //sb.AppendLine($"[Path] = {http_web_request.RequestUri.PathAndQuery}");
                //sb.AppendLine($"[Headers] = {http_web_request.Headers}");
                //foreach (string hdr_name in http_web_request.Headers.AllKeys)
                //{
                //    sb.AppendLine($"{hdr_name}: {http_web_request.Headers[hdr_name]}");
                //}
                //sb.AppendLine();
                //sb.AppendLine($"[Headers-Accept] = {http_web_request.Accept}");
                //sb.AppendLine($"[Headers-Accept] = {http_web_request.ContentType}");
                //sb.AppendLine();
                //sb.AppendLine($"[Credentials] = {http_web_request.Credentials}");
                sb.AppendLine($"----------------------------------------------------------------------------");

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
    }
} 
