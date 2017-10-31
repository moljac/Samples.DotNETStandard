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
        public async Task<Client> RequestGetAsync()
        {
            this
                .Method("GET")
                //.Headers()            // default headers
                //.Parameters()         // Data/Parameters
                ;

            foreach (KeyValuePair<Uri, ClientImplementation<HttpRequestMessage>> kvp in this.RequestImplementationObjects)
            {
                Uri uri = kvp.Key;
                HttpRequestMessage http_request_message = kvp.Value.ImplementationObject;

                RequestSetup(http_request_message);

                using (HttpClient http_client = new HttpClient())
                {
                    HttpResponseMessage response = await http_client.SendAsync(http_request_message);

                    this.ResponseImplementationObjects.Add(uri, response);
                }
            }

            return this;
        }

    }
} 
