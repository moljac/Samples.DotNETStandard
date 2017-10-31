using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

using HolisticWare.Net;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
    {
        public async Task<string> ResponseAsStringAsync(Uri uri)
        {
            HttpWebResponse http_web_response = this.ResponseImplementationObjects[uri];

            string response_string = null;

            using (StreamReader reader = new StreamReader(http_web_response.GetResponseStream()))
            {
                response_string = await reader.ReadToEndAsync();
            }

            return response_string;
        }
    }
} 
