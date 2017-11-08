using System;
using System.Text;

using HolisticWare.Net.HTTP;

#if NETSTANDARD1_0

using System.Net;

namespace HolisticWare.Net.HTTP
{
    public static partial class HttpWebResponseExtensionMethods
    {
        public static string ToString(this HttpWebResponse response, string format="R")
        {
            StringBuilder sb = new StringBuilder();

            switch (format.ToUpperInvariant())
            {
                case "R":
                case "RAW":
                    sb.AppendLine(response.ToStringRaw());
                    break;
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
                                
            return sb.ToString();
        }

        public static string ToStringRaw(this HttpWebResponse response)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public static string ToStringImplementation(this HttpWebResponse response)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"[Method]            = {response.Method}");
            sb.AppendLine($"[StatusCode]        = {response.StatusCode}");
            sb.AppendLine($"[StatusDescription] = {response.StatusDescription}");

            sb.AppendLine($"[RequestUri]        = {response.ResponseUri}");
            sb.AppendLine($"[RequestUri.OriginalString] = {response.ResponseUri.OriginalString}");
            sb.AppendLine($"[RequestUri.AbsolutePath]   = {response.ResponseUri.AbsolutePath}");
            sb.AppendLine($"[RequestUri.AbsoluteUri]    = {response.ResponseUri.AbsoluteUri}");
            sb.AppendLine($"[RequestUri.Fragment]       = {response.ResponseUri.Fragment}");
            sb.AppendLine($"[RequestUri.PathAndQuery]   = {response.ResponseUri.PathAndQuery}");
            sb.AppendLine($"[RequestUri.Query]          = {response.ResponseUri.Query}");
            sb.AppendLine($"[RequestUri.Host]           = {response.ResponseUri.Host}");

            sb.AppendLine($"[SupportsHeaders]     = {response.SupportsHeaders}");
            sb.AppendLine($"[Headers]             = {response.Headers}");
            sb.AppendLine($"[Headers-ContentType] = {response.ContentType}");

            sb.AppendLine($"[ContentType]     = {response.ContentType}");
            sb.AppendLine($"[ContentLength]   = {response.ContentLength}");

            sb.AppendLine($"[]             = {response.Cookies}");

            #if ! NETSTANDARD1_0
            sb.AppendLine($"[ProtocolVersion]   = {response.ProtocolVersion}");
            sb.AppendLine($"[Server]            = {response.Server}");
            sb.AppendLine($"[Headers-Accept]      = {response.Accept}");
            sb.AppendLine($"[Headers-ContentType] = {response.CharacterSet}");
            sb.AppendLine($"[ContentEncoding] = {response.ContentEncoding}");
            sb.AppendLine($"[]             = {response.IsFromCache}");
            sb.AppendLine($"[]             = {response.LastModified}");

            sb.AppendLine($"[]             = {response.IsMutuallyAuthenticated}");
            sb.AppendLine($"[Credentials]         = {response.Credentials}");
            #endif
                             
            return sb.ToString();
        }
    }
}
#endif