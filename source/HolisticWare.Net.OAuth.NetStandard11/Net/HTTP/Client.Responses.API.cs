using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.IO;

using HolisticWare.Net;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
    {
        public async Task<string> ResponseAsStringAsync(Uri uri)
        {
            HttpResponseMessage http_response_message = this.ResponseImplementationObjects[uri];

            string response_string = await http_response_message.Content.ReadAsStringAsync();

            return response_string;
        }
    }
} 
