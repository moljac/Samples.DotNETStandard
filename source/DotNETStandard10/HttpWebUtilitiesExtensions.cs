using System.Threading.Tasks;
using System.Net;

namespace ClassesToTest.Shared.DotNetStandard1_0
{
    public static class HttpWebUtilitiesExtensions
    {
        public static Task<WebResponse> GetResponseAsync
                            (
                                this System.Net.WebRequest http_web_request
                            )
        {
            Task<WebResponse> task = null;

            task = Task.Factory.FromAsync<WebResponse>
                            (
                                http_web_request.BeginGetResponse,
                                http_web_request.EndGetResponse,
                                null
                            );

            return task;
        }    
    }
}
