using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.Net.Http;
using System.IO;

namespace HolisticWare.Net.HTTP
{
    public partial class Client
    {
        public async Task<Client> RequestPostAsync(IDictionary<string, string> data)
        {
            this
                .Method("POST")
                //.Headers()            // default headers
                //.Parameters()         // Data/Parameters
                ;

            QueryParameters qp = new QueryParameters(data);
            string data_string = qp.Encode().ToString("F");

            await this.RequestPostAsync(data_string);

            return this;
        }

        public async Task<Client> RequestPostAsync(string data_string)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data_string);

            foreach (KeyValuePair<Uri, ClientImplementation<HttpRequestMessage>> kvp in this.RequestImplementationObjects)
            {
                Uri uri = kvp.Key;
                HttpRequestMessage http_request_message = kvp.Value.ImplementationObject;

                RequestSetup(http_request_message);

                http_request_message.Content =
                                        new StringContent(data_string)
                                        //new ByteArrayContent("")
                                        ;

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
