using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
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

using HolisticWare.Net;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
    {

        public async Task<Client> RequestGetAsync()
        {
            this
                .Method("GET")
                //.Headers()            // default headers
                //.Parameters()         // Data/Parameters
                ;


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
                ImplementationResponse response = (ImplementationResponse)await request.GetResponseAsync();
                this.ResponseImplementationObjects.Add(uri, response);
                #else
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
