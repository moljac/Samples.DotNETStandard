using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace HolisticWare.Net.HTTP
{
    public partial class Client
    {
        public Client()
        {
            this.HttpRequestSetup = HttpRequestSetupImplementation;

            return;
        }

        public Func<HttpWebRequest, HttpWebRequest> HttpRequestSetup;

        protected HttpWebRequest HttpRequestSetupImplementation(HttpWebRequest web_request)
        {
            /*
            http_web_request.Method = "GET";
            http_web_request.Accept = "";
            http_web_request.ContentType = "";
            http_web_request.CookieContainer = null;

            http_web_request.AllowReadStreamBuffering = false;
            http_web_request.Credentials = null;
            http_web_request.UseDefaultCredentials = false;
            */

            /*
            WebHeaderCollection web_header_collection = 
            new WebHeaderCollection()
            null    
            ;
            web_header_collection[""] = "";
            http_web_request.Headers = web_header_collection;
            */

            //CookieContainer cookie_conatiner = new CookieContainer();
            //cookie_conatiner.Add
            // (
            //     new Uri(url),
            //     new Cookie("__utmc", "#########")
            //     {
            //         Domain = "http://xamarin.com"
            //     }
            //);

            return web_request;
        }
    }
} 
