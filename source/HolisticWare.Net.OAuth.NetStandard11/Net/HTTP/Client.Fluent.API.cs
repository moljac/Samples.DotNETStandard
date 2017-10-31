using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// HTTP Client
    /// .NET Standard 1.0 
    /// implemented with
    ///         HttpRequestMessage  (WebRequest) 
    ///         HttpResponseMessage (WebResponse) 
    /// </summary>
    public partial class Client
    {
        public Client UrlEndpoint(Uri url)
        {
            if (null == url)
            {
                throw new ArgumentException("url");
            }

            if (null == this.EndPoints)
            {
                this.EndPoints = new List<Uri>();
            }

            if (null == this.RequestImplementationObjects)
            {
                this.RequestImplementationObjects = new Dictionary<Uri, ClientImplementation<HttpRequestMessage>>();
            }

            HttpRequestMessage http_request_message = new HttpRequestMessage()
            {
                Method = new HttpMethod(this.RequestMethodVerb),
                RequestUri = url,
            };

            this.EndPoints.Add(url);
            this.RequestImplementationObjects.Add(url, http_request_message);

            return this;
        }
    }
} 
