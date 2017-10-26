using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace HolisticWare.Net.HTTP
{
    public static class HttpWebUtilitiesExtensions
    {
        public static Task<WebResponse> GetResponseAsync
                                            (
                                                this System.Net.WebRequest http_web_request
                                            )
        {
            Task<WebResponse> task = Task.Factory.FromAsync<WebResponse>
                                                    (
                                                        http_web_request.BeginGetResponse,
                                                        http_web_request.EndGetResponse,
                                                        null
                                                    );

            return task;
        }

        public static Task<Stream> GetRequestStreamAsync
                                            (
                                                this System.Net.WebRequest http_web_request
                                            )
        {
            Task<Stream> task = Task.Factory.FromAsync<Stream>
                                                    (
                                                        http_web_request.BeginGetRequestStream,
                                                        http_web_request.EndGetRequestStream,
                                                        null
                                                    );

            return task;
        }
    }
}
