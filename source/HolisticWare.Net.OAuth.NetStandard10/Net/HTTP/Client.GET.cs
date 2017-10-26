using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

using HolisticWare.Net;

namespace HolisticWare.Net.HTTP
{
    public partial class Client
    {
        public async Task<HttpWebResponse> HttpGetAsync
                                            (
                                                string url,
                                                IDictionary<string, string> query_map = null
                                            )
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }

            string query = null;

            if (null != query_map)
            {
                QueryParameters qp = new QueryParameters(query_map);
                query = qp.ToString("F"); // format query parameters for query (F for fragment)
            }

            StringBuilder url_sb = new StringBuilder(url).Append("?").Append(query);

            // web_request = new System.Net.WebRequest(); // cannot create instance
            http_web_request =
                // new System.Net.HttpWebRequest()
                System.Net.WebRequest.CreateHttp(url_sb.ToString())
                ;

            this.HttpRequestSetup(http_web_request);
            http_web_response = (HttpWebResponse)await http_web_request.GetResponseAsync();

            return http_web_response;
        }

        public async Task<string> HttpGetStringAsync
                                            (
                                                string url,
                                                IDictionary<string, string> query_map = null
                                            )
        {
            string query = null;

            if(null != query_map)
            {
                QueryParameters qp = new QueryParameters(query_map);
                query = qp.ToString("F"); // format query parameters for query (F for fragment)
            }

            string response_string = await this.HttpGetStringAsync(url, query);

            return response_string;
        }

        public async Task<string> HttpGetStringAsync
                                            (
                                                string url,
                                                string query_url_encoded = null
                                            )
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }

            StringBuilder url_sb = new StringBuilder(url).Append("&").Append(query_url_encoded);

            http_web_response = await this.HttpGetAsync(url_sb.ToString());

            string response_string = null;

            using (StreamReader sr = new StreamReader(http_web_response.GetResponseStream()))
            {
                response_string = await sr.ReadToEndAsync();
            }

            return response_string;
        }

    }
} 
