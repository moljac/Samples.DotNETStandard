using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.IO;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
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

            foreach (KeyValuePair<Uri, ClientImplementation<HttpWebRequest>> kvp in this.RequestImplementationObjects)
            {

                Uri uri = kvp.Key;
                HttpWebRequest request = kvp.Value.ImplementationObject;

                RequestSetup(request);


                using (Stream stream = await request.GetRequestStreamAsync())
                {
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                    await stream.FlushAsync();
                }

                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

                this.ResponseImplementationObjects.Add(uri, response);
            }

            return this;
        }

    }
} 
