using System;

namespace DotNETStandard10
{
    /// <summary>
    /// Web request.
    /// </summary>
    /// <see cref="http://packagesearch.azurewebsites.net/?q=WebRequest"/>
    public class WebRequest
    {
        public WebRequest()
        {
            System.Net.WebRequest web_request = null;
            System.Net.HttpWebRequest http_web_request = null;
            System.Net.HttpRequestHeader http_request_header;
            System.Net.HttpWebResponse http_web_response = null;

            // web_request = new System.Net.WebRequest(); // cannot create instance
            http_web_request =
                // new System.Net.HttpWebRequest()
                System.Net.WebRequest.CreateHttp("http://xamarin.com");
            http_web_request.Accept = "";
            http_web_request.ContentType = "";
            http_web_request.CookieContainer = new System.Net.CookieContainer()
            {
            };
            http_web_request.AllowReadStreamBuffering = false;
            http_web_request.Credentials = null;   
            http_web_request.Headers = new System.Net.WebHeaderCollection();
            http_web_request.UseDefaultCredentials = true;
            http_web_request.Method = "";                       // GET, POST, 

            return;
        }
    }
}
