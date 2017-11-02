using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using System.Net;
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
    public partial class Client : IClient, IFormattable
    {
        public List<Uri> EndPoints
        {
            get;
            set;
        }


        public Client UrlEndpoint(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("url");
            }

            return this.UrlEndpoints(url);
        }

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
                this.RequestImplementationObjects =
                        new Dictionary
                                <
                                    // Uri endpoints for requests
                                    Uri,
                                    // Request Details (platform specific)
                                    ClientRequestImplementation<ImplementationRequest>
                                >();
            }

            this.EndPoints.Add(url);
            this.RequestImplementationObjects
                    .Add
                        (
                            url,
                            #if NETSTANDARD1_0
                            // .NET Standard 1.0
                            // HttpWebRequest 
                            (ImplementationRequest)WebRequest.Create(url)
                            #else
                            // .NET Standard 1.1+
                            // HttpRequestMessage for HttpClient
                            new ImplementationRequest()
                            {
                                Method = new System.Net.Http.HttpMethod(this.RequestMethodVerb),
                                RequestUri = url,
                            }
                            #endif

                        );

            return this;
        }

        public Client UrlEndpoints(IEnumerable<Uri> urls)
        {
            if (null == urls || urls.Count() < 1)
            {
                throw new ArgumentException("urls");
            }

            this.EndPoints.AddRange(urls);

            return this;
        }

        public Client UrlEndpoints(string urls)
        {
            if (string.IsNullOrEmpty(urls))
            {
                throw new ArgumentException("urls");
            }

            string[] urls_array = urls.Split
                                        (
                                            new char[] { ' ', ';' },
                                            StringSplitOptions.RemoveEmptyEntries
                                        );

            List<Uri> uris = new List<Uri>();
            foreach (string url in urls_array)
            {
                Uri u = null;
                try
                {
                    u = new Uri(url);
                }
                catch (Exception exc)
                {
                    throw new ArgumentException("url is not Uri", exc);
                }

                uris.Add(u);

            }

            if (null == this.EndPoints)
            {
                this.EndPoints = new List<Uri>();
            }

            //this.EndPoints.AddRange(uris);
            foreach (Uri u in uris)
            {
                this.UrlEndpoint(u);
            }

            return this;
        }

        protected HashSet<string> http_methods = new HashSet<string>()
        {
            "GET",
            "POST",
            "HEAD",
            "PUT",
            "DELETE",
            "CONNECT",
            "OPTIONS",
            "TRACE",
            "PATCH",
        };

        /// <summary>
        /// HTTP Request Method/Verb
        /// </summary>
        /// <value>The request method.</value>
        public string RequestMethodVerb
        {
            get;
            set;
        }

        public Client Method(string method)
        {
            if (!http_methods.Contains(method.ToUpper()))
            {
                throw new ArgumentException($"{method} is not HTTP method/verb");
            }

            this.RequestMethodVerb = method;

            return this;
        }

        public Dictionary<string, string> RequestHeaders
        {
            get;
            set;
        }

        public Client Headers(List<string> headers)
        {
            Dictionary<string, string> headers_dictionary = new Dictionary<string, string>();

            foreach (string hdr in headers)
            {
                string[] header_parts = hdr.Split(new char[] { ':' });
                string header_name = header_parts[0];
                string header_value = header_parts[1];

                headers_dictionary[header_name] = header_value;
            }

            return this.Headers(headers_dictionary);
        }

        public Client Headers(IDictionary<string, string> headers)
        {
            this.RequestHeaders = new Dictionary<string, string>(headers);

            return this;
        }

        public string DataAsString
        {
            get;
            set;
        }

        public string ParametersAsString
        {
            get
            {
                return this.DataAsString;
            }
            set
            {
                this.DataAsString = value;

                return;
            }
        }

        public Client Parameters(IDictionary<string, string> data_parameters)
        {
            this.DataAsString = string.Join("&", data_parameters?.Select(x => x.Key + "=" + x.Value));

            return this;
        }

        public Client Data(IDictionary<string, string> data_parameters)
        {
            return this.Parameters(data_parameters);
        }


        public Client ParameterEncodings(IDictionary<string, Func<string, string>> parameters)
        {
            throw new NotImplementedException();
        }
    }
} 
