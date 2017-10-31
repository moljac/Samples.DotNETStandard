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
        public string ToStringRaw()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Uri uri in this.EndPoints)
            {
                sb
                    .Append(this.RequestMethodVerb)
                    .Append(" ")
                    .Append(uri.PathAndQuery)
                    .Append(" ")
                    .AppendLine("HTTP/v.v");

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

            sb.AppendLine($"[Implementation Object] = {RequestImplementationObjects?.GetType().ToString()}");

            foreach (KeyValuePair<Uri, ClientImplementation<HttpWebRequest>> kvp in this.RequestImplementationObjects)
            {
                Uri uri = kvp.Key;
                HttpWebRequest request = kvp.Value.ImplementationObject;
                sb.AppendLine($"uri.OriginalString = {uri.OriginalString}");
                sb.AppendLine($"uri.AbsoluteUri    = {uri.AbsoluteUri}");
                sb.AppendLine($"uri.AbsolutePath   = {uri.AbsolutePath}");
                sb.AppendLine($"uri.Host           = {uri.Host}");
                sb.AppendLine($"Uri.PathAndQuery   = {uri.PathAndQuery}");

                sb.AppendLine();
                sb.AppendLine($"[Method] = {request.Method}");
                sb.AppendLine($"[RequestUri] = {request.RequestUri}");
                sb.AppendLine($"[Path] = {request.RequestUri.PathAndQuery}");
                sb.AppendLine($"[Headers] = {request.Headers}");
                sb.AppendLine();
                sb.AppendLine($"[Headers-Accept]      = {request.Accept}");
                sb.AppendLine($"[Headers-ContentType] = {request?.ContentType}");
                sb.AppendLine();
                sb.AppendLine($"[Credentials] = {request.Credentials}");
            }

            foreach (Uri uri in this.EndPoints)
            {
                sb.AppendLine($"uri.OriginalString = {uri.OriginalString}");
                sb.AppendLine($"uri.AbsoluteUri    = {uri.AbsoluteUri}");
                sb.AppendLine($"uri.AbsolutePath   = {uri.AbsolutePath}");
                sb.AppendLine($"uri.Host           = {uri.Host}");
                sb.AppendLine($"Uri.PathAndQuery   = {uri.PathAndQuery}");
            }

            return sb.ToString();
        }
    }
} 
