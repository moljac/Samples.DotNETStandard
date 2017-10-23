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
        public async Task OAuthPostAsync
                                (
                                    string uri_request_token,
                                    string data_body_token_request,
                                    string content_type = "application/x-www-form-urlencoded",
                                    string accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
                                )
        {
            byte[] bytes = null;

            //bytes = Encoding.ASCII.GetBytes(data_body_token_request);
            bytes = Encoding.UTF8.GetBytes(data_body_token_request);

            HttpWebRequest http_request = (HttpWebRequest)WebRequest.Create(uri_request_token);
            http_request.Method = "POST";
            http_request.ContentType = content_type;
            http_request.Accept = accept;
            //tokenRequest.ContentLength = bytes.Length;

            using (Stream stream = await http_request.GetRequestStreamAsync())
            {
                await stream.WriteAsync(bytes, 0, bytes.Length);
                await stream.FlushAsync();
            }

            return;
        }
    }
} 
