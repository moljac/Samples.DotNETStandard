using System;

namespace DotNETStandard10
{
    public partial class HttpClient
    {
        public HttpClient()
        {
            #if NETSTANDARD1_1
            System.Net.Http.HttpClient http_client = null;

            http_client = new System.Net.Http.HttpClient();
            #endif

            return;

        }
    }
}
