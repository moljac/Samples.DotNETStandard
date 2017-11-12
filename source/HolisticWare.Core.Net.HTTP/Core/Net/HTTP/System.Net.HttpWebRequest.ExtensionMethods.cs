using System;
using System.Text;

#if NETSTANDARD1_0
using System.Net;

namespace Core.Net.HTTP
{
    public static partial class HttpWebRequestExtensionMethods
    {
        public static string ToString(this HttpWebRequest request, string format="R")
        {
            StringBuilder sb = new StringBuilder();

            switch (format.ToUpperInvariant())
            {
                case "R":
                case "RAW":
                    sb.AppendLine(request.ToStringRaw());
                    break;
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
                                
            return sb.ToString();
        }

        public static string ToStringRaw(this HttpWebRequest request)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public static string ToStringImplementation(this HttpWebRequest request)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"[Method]            = {request.Method}");

            sb.AppendLine($"[RequestUri]        = {request.RequestUri}");
            sb.AppendLine($"[RequestUri.OriginalString] = {request.RequestUri.OriginalString}");
            sb.AppendLine($"[RequestUri.AbsolutePath]   = {request.RequestUri.AbsolutePath}");
            sb.AppendLine($"[RequestUri.AbsoluteUri]    = {request.RequestUri.AbsoluteUri}");
            sb.AppendLine($"[RequestUri.Fragment]       = {request.RequestUri.Fragment}");
            sb.AppendLine($"[RequestUri.PathAndQuery]   = {request.RequestUri.PathAndQuery}");
            sb.AppendLine($"[RequestUri.Query]          = {request.RequestUri.Query}");
            sb.AppendLine($"[RequestUri.Host]           = {request.RequestUri.Host}");

            sb.AppendLine($"[Accept]          = {request.Accept}");
            sb.AppendLine($"[CookieContainer] = {request.CookieContainer}");
            sb.AppendLine($"[HaveResponse]    = {request.HaveResponse}");
            sb.AppendLine($"[Headers]         = {request.Headers}");
            sb.AppendLine($"[SupportsCookieContainer] = {request.SupportsCookieContainer}");
            sb.AppendLine($"[UseDefaultCredentials]   = {request.UseDefaultCredentials}");

            #if !NETSTANDARD1_0
            sb.AppendLine($"[Address]        = {request.Address}");
            sb.AppendLine($"[UserAgent]           = {request.UserAgent}");
            sb.AppendLine($"[AllowAutoRedirect] = {request.AllowAutoRedirect}");
            sb.AppendLine($"[AuthenticationLevel] = {request.AuthenticationLevel}");
            sb.AppendLine($"[AllowReadSteamBuffering]  = {request.AllowReadSteamBuffering}");
            sb.AppendLine($"[AllowWriteStreamBuffering] = {request.AllowWriteStreamBuffering}");
            sb.AppendLine($"[AutomaticDecompression]           = {request.AutomaticDecompression}");
            sb.AppendLine($"[CachePolicy]           = {request.CachePolicy}");
            sb.AppendLine($"[ClientCertificates]           = {request.ClientCertificates}");
            sb.AppendLine($"[ContinueTimeout]           = {request.ContinueTimeout}");
            sb.AppendLine($"[ConnectionGroupName]           = {request.ConnectionGroupName}");
            sb.AppendLine($"[Date]           = {request.Date}");
            sb.AppendLine($"[Expect]           = {request.Expect}");
            sb.AppendLine($"[Host]           = {request.Host}");
            sb.AppendLine($"[IfModifiedSince]           = {request.IfModifiedSince}");
            sb.AppendLine($"[ImpersonationLevel]           = {request.ImpersonationLevel}");
            sb.AppendLine($"[KeepAlive]           = {request.KeepAlive}");
            sb.AppendLine($"[MaximumAutomaticRedirections]           = {request.MaximumAutomaticRedirections}");
            sb.AppendLine($"[MaximumResponseHeadersLength]           = {request.MaximumResponseHeadersLength}");
            sb.AppendLine($"[MediaType]           = {request.MediaType}");
            sb.AppendLine($"[Pipelined]           = {request.Pipelined}");
            sb.AppendLine($"[PreAuthenticate]           = {request.PreAuthenticate}");
            sb.AppendLine($"[ProtocolVersion]           = {request.ProtocolVersion}");
            sb.AppendLine($"[Proxy]           = {request.Proxy}");
            sb.AppendLine($"[ReadWriteTimeout]           = {request.ReadWriteTimeout}");
            sb.AppendLine($"[ReadWriteTimeout]           = {request.ReadWriteTimeout}");
            sb.AppendLine($"[Referer]           = {request.Referer}");
            sb.AppendLine($"[SendChunked]           = {request.SendChunked}");
            sb.AppendLine($"[ServicePoint]           = {request.ServicePoint}");
            sb.AppendLine($"[Timeout]           = {request.Timeout}");            
            sb.AppendLine($"[TransferEncoding]           = {request.TransferEncoding}");
            #endif
                             
            return sb.ToString();
        }
    }
}
#endif