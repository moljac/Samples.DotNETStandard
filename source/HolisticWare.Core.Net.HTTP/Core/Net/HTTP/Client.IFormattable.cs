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
                string f_lower = f.ToLowerInvariant();

                if (f_lower == "d" || f_lower == "debug")
                {
                    sb.AppendLine(this.ToStringAbstractionAPI(f));
                    sb.AppendLine(this.ToStringImplementationObject(f));
                    sb.AppendLine(this.ToStringRaw(f));

                    break;
                }

                if (f_lower == "a" || f_lower == "abstraction")
                {
                    sb.AppendLine(this.ToStringAbstractionAPI());
                    continue;
                }

                if (f_lower == "r" || f_lower == "raw")
                {
                    sb.AppendLine(this.ToStringRaw());
                    continue;
                }

                if (f_lower == "i" || f_lower == "implementation")
                {
                    sb.AppendLine(this.ToStringImplementationObject());
                    continue;
                }

            }

            return sb.ToString();
        }

        public string ToStringAbstractionAPI(string format = null)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Abstraction API {this.GetType().ToString()}");

            sb.AppendLine("Uris / Endpoints:");
            foreach (Uri uri in this.EndPoints)
            {
                sb.AppendLine($"    Uri = {uri.ToString(format)}");
            }

            sb.AppendLine($"Headers:");
            foreach (KeyValuePair<string, string> hdr in this.RequestHeaders)
            {
                sb.Append($"    {hdr.Key}").Append(": ").AppendLine(hdr.Value);
            }

            sb.AppendLine($"DataAsString       = {this.DataAsString}");
            sb.AppendLine($"ParametersAsString = {this.ParametersAsString}");
            //foreach (KeyValuePair<string, string> hdr in this.)
            {
            }

            return sb.ToString();
        }

        public string ToStringImplementationObject(string format = null)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Uri Endpoints:" );
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

        public string ToStringRaw(string format = null)
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
    }
}
