using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

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

        public async Task<HttpResponseMessage> HttpGetAsync(string url)
        {
            HttpClient http_client = new HttpClient();

            HttpResponseMessage http_response_msg = null;

            http_response_msg = await http_client.GetAsync(url);

            return http_response_msg;
        }

        public async Task<string> HttpGetStringAsync(string url)
        {
            HttpClient http_client = new HttpClient();

            string response_string = null;

            string http_response_str = await http_client.GetStringAsync(url);

            return response_string;
        }

        protected void HttpRequestsSetup()
        {
            //http_client.BaseAddress = new Uri(url);

            //-----------------------------------------------------------------------------
            //http_client.DefaultRequestHeaders.Add();
            //http_client.DefaultRequestHeaders.TryAddWithoutValidation();

            //http_client.DefaultRequestHeaders.Accept
                    //.Add
                        //(
                        //    new MediaTypeWithQualityHeaderValue("application/json")
                        //);
            // http_client.DefaultRequestHeaders.AcceptCharset
            //http_client.DefaultRequestHeaders.AcceptEncoding
            //http_client.DefaultRequestHeaders.AcceptLanguage
            //http_client.DefaultRequestHeaders.Authorization
            //http_client.DefaultRequestHeaders.CacheControl           
            //http_client.DefaultRequestHeaders.Connection
            //http_client.DefaultRequestHeaders.ConnectionClose
            //http_client.DefaultRequestHeaders.Date
            //http_client.DefaultRequestHeaders.Expect
            //http_client.DefaultRequestHeaders.ExpectContinue           
            //http_client.DefaultRequestHeaders.From
            //http_client.DefaultRequestHeaders.Host
            //http_client.DefaultRequestHeaders.IfMatch
            //http_client.DefaultRequestHeaders.IfModifiedSince
            //http_client.DefaultRequestHeaders.IfNoneMatch           
            //http_client.DefaultRequestHeaders.IfRange
            //http_client.DefaultRequestHeaders.IfUnmodifiedSince
            //http_client.DefaultRequestHeaders.MaxForwards
            //http_client.DefaultRequestHeaders.Pragma
            //http_client.DefaultRequestHeaders.ProxyAuthorization
            //http_client.DefaultRequestHeaders.Range
            //http_client.DefaultRequestHeaders.Referrer
            //http_client.DefaultRequestHeaders.TE           
            //http_client.DefaultRequestHeaders.Trailer
            //http_client.DefaultRequestHeaders.TransferEncoding
            //http_client.DefaultRequestHeaders.TransferEncodingChunked
            //http_client.DefaultRequestHeaders.Upgrade
            //http_client.DefaultRequestHeaders.UserAgent
            //http_client.DefaultRequestHeaders.Via
            //http_client.DefaultRequestHeaders.Warning
            //-----------------------------------------------------------------------------
        }
    }
}
