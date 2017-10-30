using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Text;

using System.Net.Http;

namespace HolisticWare.Net.HTTP
{
    public partial class Client
    {

        public async Task<HttpResponseMessage> HttpGetAsync
                                                (
                                                    string url,
                                                    IDictionary<string, string> parameters
                                                )
        {
            HttpClient http_client = new HttpClient();

            HttpResponseMessage http_response_msg = null;

            http_response_msg = await http_client.GetAsync(url);

            return http_response_msg;
        }

        public async Task<string> HttpGetStringAsync
                                                (
                                                    string url,
                                                    IDictionary<string, string> parameters
                                                )
        {
            HttpClient http_client = new HttpClient();

            string response_string = null;

            string http_response_str = await http_client.GetStringAsync(url);

            return response_string;
        }

    }
} 
