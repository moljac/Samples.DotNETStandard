﻿using System;
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
                                                Dictionary<string, string> parameters = null
                                            )
        {
            // web_request = new System.Net.WebRequest(); // cannot create instance
            http_web_request =
                // new System.Net.HttpWebRequest()
                System.Net.WebRequest.CreateHttp(url)
                ;

            this.HttpRequestSetup(http_web_request);
            http_web_response = (HttpWebResponse)await http_web_request.GetResponseAsync();

            return http_web_response;
        }

        public async Task<string> HttpGetStringAsync
                                            (
                                                string url,
                                                Dictionary<string, string> query_map = null
                                            )
        {
            string query = null;

            if(null != query_map)
            {
                QueryParameters qp = new QueryParameters(query_map);
                query = qp.ToString("F"); // format query parameters for query (F for fragment)
            }

            StringBuilder url_sb = new StringBuilder(url).Append("?").Append(query);

            string response_string = null;

            http_web_response = await this.HttpGetAsync(url_sb.ToString());

            using (StreamReader sr = new StreamReader(http_web_response.GetResponseStream()))
            {
                response_string = await sr.ReadToEndAsync();
            }

            return response_string;
        }
    }
} 
