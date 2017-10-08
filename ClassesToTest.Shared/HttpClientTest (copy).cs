using System;

namespace DotNETStandard10
{
    public class HttpClientTest
    {
        public HttpClientTest()
        {
            #if !NETSTANDARD1_0
            System.Net.Http.HttpClient http_client = null;

            http_client = new System.Net.Http.HttpClient();
            #endif

            return;
        }
    }
}
