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

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// HTTP Client
    ///     implemented for .NET Standard 1.0 with
    ///         HttpWebRequest  (WebRequest) 
    ///         HttpWebResponse (WebResponse) 
    ///     implemented for .NET Standard 1.1 with
    ///         HttpRequestMessage  (WebRequest) 
    ///         HttpResponseMessage (WebResponse) 
    /// </summary>
    public partial class Client : IClient
    {
        public Client()
        {
            this.RequestMethodVerb = "GET";
            this.RequestSetup = RequestSetupImplementation;

            return;
        }

        public Func<ImplementationRequest, ImplementationRequest> RequestSetup;

        protected ImplementationRequest RequestSetupImplementation(ImplementationRequest http_request)
        {
            if (this.RequestMethodVerb == "POST")
            {
                #if NETSTANDARD1_0
                http_request.Method = this.RequestMethodVerb;
                http_request.ContentType = "application/x-www-form-urlencoded";
                #else
                #endif
            }
    
            #if NETSTANDARD1_0
            //http_web_request.AllowReadStreamBuffering = false;
            //http_web_request.Credentials = null;
            //http_web_request.UseDefaultCredentials = false;

            System.Net.WebHeaderCollection web_header_collection = new System.Net.WebHeaderCollection();
            foreach (KeyValuePair<string, string> kvp in this.RequestHeaders)
            {
                if (kvp.Key == "Accept")
                {
                    http_request.Accept = kvp.Value;
                }
                else
                {
                    http_request.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                }

                if (kvp.Key == "Content-Type")
                {
                    http_request.Accept = kvp.Value;
                }
                else
                {
                    http_request.ContentType = "application/x-www-form-urlencoded";
                }

                web_header_collection[kvp.Key] = kvp.Value;

            }
            http_request.Headers = web_header_collection;

            //CookieContainer cookie_conatiner = new CookieContainer();
            //cookie_conatiner.Add
            // (
            //     new Uri(url),
            //     new Cookie("__utmc", "#########")
            //     {
            //         Domain = "http://xamarin.com"
            //     }
            //);
#else
#endif

            return http_request;
        }


        /// <summary>
        /// Mapping for Uri and HTTP Request implementation objects (platform specific)
        /// </summary>
        /// <value>The request implementation objects.</value>
        public Dictionary
                <
                    // Uri endpoint for the request
                    Uri,
                    // Request details (platform specific details)
                    //  ClientRequestImplementation - helper class
                    //  ImplementationRequest - alias for implementation class (see top of the file)
                    ClientRequestImplementation<ImplementationRequest>
                >
                RequestImplementationObjects
        {
            get;
            set;
        } = null;

        /// <summary>
        /// Mapping for Uri and HTTP Response implementation objects (platform specific)
        /// </summary>
        public Dictionary
                <
                    // Uri endpoint for the request
                    Uri,
                    // Response details (platform specific details)
                    //  ClientResponseImplementation - helper class
                    //  ImplementationResponse - alias for implementation class (see top of the file)
                    ClientResponseImplementation<ImplementationResponse>
                >
                ResponseImplementationObjects
        {
            get;
            set;
        } = null;

    }
}
