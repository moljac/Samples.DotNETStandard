using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using System.Net;
using System.Text;

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// HTTP Client
    /// .NET Standard 1.0 
    /// implemented with
    ///         HttpWebRequest  (WebRequest) 
    ///         HttpWebResponse (WebResponse) 
    /// </summary>
    public partial class Client : IClient, IFormattable
    {
        public Client()
        {
            this.RequestMethodVerb = "GET";
            this.RequestSetup = RequestSetupImplementation;

            return;
        }

        public Func<HttpWebRequest, HttpWebRequest> RequestSetup;


        protected HttpWebRequest RequestSetupImplementation(HttpWebRequest http_web_request)
        {
            http_web_request.Method = this.RequestMethodVerb;
            if (this.RequestMethodVerb == "POST")
            {
                http_web_request.ContentType = "application/x-www-form-urlencoded";
            }

            //http_web_request.AllowReadStreamBuffering = false;
            //http_web_request.Credentials = null;
            //http_web_request.UseDefaultCredentials = false;

            WebHeaderCollection web_header_collection = new WebHeaderCollection();
            foreach(KeyValuePair<string, string> kvp  in this.RequestHeaders)
            {
                if (kvp.Key == "Accept")
                {
                    http_web_request.Accept = kvp.Value;
                }
                else
                {
                    http_web_request.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                }

                if (kvp.Key == "Content-Type")
                {
                    http_web_request.Accept = kvp.Value;
                }
                else
                {
                    http_web_request.ContentType = "application/x-www-form-urlencoded";
                }

                web_header_collection[kvp.Key] = kvp.Value;

            }
            http_web_request.Headers = web_header_collection;

            //CookieContainer cookie_conatiner = new CookieContainer();
            //cookie_conatiner.Add
            // (
            //     new Uri(url),
            //     new Cookie("__utmc", "#########")
            //     {
            //         Domain = "http://xamarin.com"
            //     }
            //);

            return http_web_request;
        }

    }
} 
