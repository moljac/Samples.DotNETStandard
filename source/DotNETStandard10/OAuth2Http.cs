﻿using System;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ClassesToTest.Shared.DotNetStandard1_0
{
    /// <summary>
    /// Web request.
    /// </summary>
    /// <see cref="http://packagesearch.azurewebsites.net/?q=WebRequest"/>
    public class OAuth2Http
    {
        public OAuth2Http()
        {
            return;
        }

        System.Net.HttpWebRequest http_web_request = null;
        System.Net.HttpWebResponse http_web_response = null;
        //System.Net.WebRequest web_request = null;
        //System.Net.HttpRequestHeader http_request_header;

        public async Task<string> HttpGetAsync(string url)
        {
            string response_string = null;


            // web_request = new System.Net.WebRequest(); // cannot create instance
            http_web_request =
                // new System.Net.HttpWebRequest()
                System.Net.WebRequest.CreateHttp(url)
                ;
            
            http_web_request.Method = "GET";
            http_web_request.Accept = "";
            http_web_request.ContentType = "";

            http_web_request.CookieContainer = null;

            http_web_request.AllowReadStreamBuffering = false;
            http_web_request.Credentials = null;
            http_web_request.UseDefaultCredentials = false;

            http_web_response = (HttpWebResponse)await http_web_request.GetResponseAsync();

            using (StreamReader sr = new StreamReader(http_web_response.GetResponseStream()))
            {
                response_string = await sr.ReadToEndAsync();
            }

            return response_string;
        }

        protected void HttpRequestsSetup()
        {
            //WebHeaderCollection web_header_collection = 
                                    //new WebHeaderCollection()
                                    //null    
                                    //;
            //web_header_collection[""] = "";
            //http_web_request.Headers = web_header_collection;

            //CookieContainer cookie_conatiner = new CookieContainer();
            //cookie_conatiner.Add
            // (
            //     new Uri(url),
            //     new Cookie("__utmc", "#########")
            //     {
            //         Domain = "http://xamarin.com"
            //     }
            //);

            return;
        }
    }
}
