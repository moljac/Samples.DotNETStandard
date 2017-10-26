using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.IO;

namespace HolisticWare.Net.HTTP
{
    public partial class Client
    {
        public async Task<HttpWebResponse> HttpPostAsync
                                            (
                                                string url,
                                                IDictionary<string, string> data,
                                                IDictionary<string, string> headers = null
                                            )
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }

            HttpWebRequest http_request = (HttpWebRequest)WebRequest.Create(url);
            http_request.Method = "POST";

            foreach (KeyValuePair<string, string> kvp in headers)
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

            }

            QueryParameters qp = new QueryParameters(data);
            string data_string = qp.Encode().ToString("F");
            byte[] bytes = Encoding.UTF8.GetBytes(data_string);
                
            //tokenRequest.ContentLength = bytes.Length;

            using (Stream stream = await http_request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(bytes, 0, bytes.Length);
                await stream.FlushAsync();
            }

            this.HttpRequestSetup(http_web_request);
            http_web_response = (HttpWebResponse)await http_web_request.GetResponseAsync();

            return http_web_response;
        }

    }
} 
