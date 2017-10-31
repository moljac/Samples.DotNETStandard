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
        public Client()
        {
            this.RequestMethodVerb = "GET";
            this.RequestSetup = RequestSetupImplementation;

            return;
        }

        public Func<HttpRequestMessage, HttpRequestMessage> RequestSetup;

        protected HttpRequestMessage RequestSetupImplementation(HttpRequestMessage http_request_message)
        {

            return http_request_message;
        }
    }
} 
