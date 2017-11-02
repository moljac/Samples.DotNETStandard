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

using HolisticWare.Net;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
    {
        public async Task<string> ResponseAsStringAsync(Uri uri)
        {
            ImplementationResponse response = this.ResponseImplementationObjects[uri];

            string response_string = null;

            #if NETSTANDARD1_0
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                response_string = await reader.ReadToEndAsync();
            }
            #else
            response_string = await response.Content.ReadAsStringAsync();
            #endif
            return response_string;
        }

    }
} 
