using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.IO;
//-------------------------------------------------------------------------------------------------
// Aliases for readibility
#if NETSTANDARD1_0
// all platforms, non optimized
using ImplementationRequest = System.Net.HttpWebRequest;
using ImplementationResponse = System.Net.HttpWebResponse;
#else
// ! all platforms (missing Windows Phone 8 Silverlight), optimized for some Xamarin platforms:
//  
using ImplementationRequest = System.Net.Http.HttpRequestMessage;
using ImplementationResponse = System.Net.Http.HttpResponseMessage;
#endif
//-------------------------------------------------------------------------------------------------

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

            foreach
                (
                    KeyValuePair<Uri, ClientRequestImplementation<ImplementationRequest>> kvp
                    in this.RequestImplementationObjects
                )
            {

                Uri uri = kvp.Key;
                ImplementationRequest request = kvp.Value.ImplementationObject;

                RequestSetup(request);

                #if NETSTANDARD1_0
                using (Stream stream = await request.GetRequestStreamAsync())
                {
                    await stream.WriteAsync(bytes, 0, bytes.Length);
                    await stream.FlushAsync();
                }

                ImplementationResponse response = (ImplementationResponse)await request.GetResponseAsync();
                this.ResponseImplementationObjects.Add(uri, response);

                #else
                request.Content =
                            new System.Net.Http.StringContent(data_string)
                            //new System.Net.Http.ByteArrayContent(new byte[]{})
                            ;

                using (System.Net.Http.HttpClient http_client = new System.Net.Http.HttpClient())
                {
                    ImplementationResponse response = await http_client.SendAsync(request);

                    this.ResponseImplementationObjects.Add(uri, response);
                }

                #endif
            }

            return this;
        }

    }
} 
