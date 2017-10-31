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
        public async Task<Client> RequestGetAsync()
        {
            this
                .Method("GET")
                //.Headers()            // default headers
                //.Parameters()         // Data/Parameters
                ;

            foreach (KeyValuePair<Uri, ClientImplementation<HttpWebRequest>> kvp in this.RequestImplementationObjects)
            {
                Uri uri = kvp.Key;
                HttpWebRequest request = kvp.Value.ImplementationObject;

                RequestSetup(request);

                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

                this.ResponseImplementationObjects.Add(uri, response);
            }

            return this;
        }

    }
} 
