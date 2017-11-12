using System;
using System.Collections.Generic;
using System.Text;

//-------------------------------------------------------------------------------------------------
// Aliases for readibility
#if NETSTANDARD1_0
// all platforms, non optimized
using ImplementationRequest = System.Net.HttpWebRequest;
using ImplementationResponse = System.Net.HttpWebResponse;
#else
// ! all platforms (missing Windows Phone 8 Silverlight), optimized for some Xamarin platforms:
//  
using ImplementationRequest = System.Net.Http.HttpRequestMessage;
using ImplementationResponse = System.Net.Http.HttpResponseMessage;
#endif
//-------------------------------------------------------------------------------------------------

namespace Core.Net.HTTP
{
    public partial class Client : IClient
    {
        public override string ToString()
        {
            return this.ToString("R", System.Globalization.CultureInfo.CurrentCulture);
        }


        public string ToString(string format)
        {
            return this.ToString(format, System.Globalization.CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format))
            {
                format = "R";
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

            foreach (string f in formats)
            {
                sb.AppendLine("---------------------------------------------------------------------");
                sb.AppendLine($"Format = {f}");
                sb.AppendLine($"{this.ToString(f, System.Globalization.CultureInfo.CurrentCulture)}");
                sb.AppendLine();
                sb.AppendLine("---------------------------------------------------------------------");
                sb.AppendLine();
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

                sb.AppendLine();
                sb.Append(this.RequestMethodVerb).Append(" ").Append(uri.PathAndQuery)
                  .Append("HTTP/").AppendLine();

                foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
                {
                    sb.Append(hdr.Key).Append(": ").AppendLine(hdr.Value);
                }

                return sb.ToString();
            }

            foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
            {
                sb.Append(hdr.Key).Append(": ").AppendLine(hdr.Value);
            }

            sb.AppendLine($"DataAsString       = {this.DataAsString}");
            sb.AppendLine($"ParametersAsString = {this.ParametersAsString}");
            //            foreach (KeyValuePair<string, string> hdr in this.)
            {
            }

            return sb.ToString();
        }

        public string ToStringRaw()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Uri uri in this.EndPoints)
            {
                sb
                    .Append(this.RequestMethodVerb).Append(" ").Append(uri.PathAndQuery).Append(" ")
                    .Append("HTTP/").AppendLine()
                    .AppendLine();

                if (null != this.RequestHeaders)
                {
                    foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
                    {
                        sb.Append(hdr.Key).Append(": ").AppendLine(hdr.Value);
                    }
                }
            }

            return sb.ToString();
        }

        public string ToStringImplementationObject()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine("Endpoints:" );
            foreach (Uri uri in this.EndPoints)
            {
                sb.AppendLine($"uri.OriginalString = {uri.OriginalString}");
                sb.AppendLine($"uri.AbsoluteUri    = {uri.AbsoluteUri}");
                sb.AppendLine($"uri.AbsolutePath   = {uri.AbsolutePath}");
                sb.AppendLine($"uri.Host           = {uri.Host}");
                sb.AppendLine($"Uri.PathAndQuery   = {uri.PathAndQuery}");
            }
            sb.AppendLine("------------------------------------------------------------------------");


            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine("KeyValuePair<Uri, ClientRequestImplementation<ImplementationRequest>>");
            sb.AppendLine($"[Implementation Object] = {RequestImplementationObjects?.GetType().ToString()}");
            sb.AppendLine();
            foreach 
                (
                    KeyValuePair<Uri, ClientRequestImplementation<ImplementationRequest>> kvp 
                     in this.RequestImplementationObjects
                )
            {
                Uri uri = kvp.Key;

                sb.AppendLine(uri.ToString("D"));
                sb.AppendLine($"uri.OriginalString = {uri.OriginalString}");
                sb.AppendLine($"uri.AbsoluteUri    = {uri.AbsoluteUri}");
                sb.AppendLine($"uri.AbsolutePath   = {uri.AbsolutePath}");
                sb.AppendLine($"uri.Host           = {uri.Host}");
                sb.AppendLine($"Uri.PathAndQuery   = {uri.PathAndQuery}");

                ImplementationRequest request = kvp.Value.ImplementationObject;
                sb.AppendLine(request.ToString());
            }
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine();


            return sb.ToString();
        }
    }
}
