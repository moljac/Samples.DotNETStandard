using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Net;

namespace HolisticWare.Net.Net.HTTP
{
    /// <summary>
    /// HTTP Client interface
    ///     Fluent interface
    ///     mimic CURL
    /// </summary>
    public interface IClient
    {
        IClient UrlEndpoint(string url);

        IClient UrlEndpoint(Uri url);

        IClient Method(string method);

        IClient Headers(List<string> headers);

        IClient Headers(IDictionary<string, string> headers);

        IClient Parameters(IDictionary<string, string> parameters);

        IClient ParameterEncodings(IDictionary<string, Func<string, string> > parameters);

        Task<HttpWebResponse> HttpGetAsync
                                    (
                                        string url,
                                        IDictionary<string, string> query_map = null
                                    );

         Task<string> HttpGetStringAsync
                                    (
                                        string url,
                                        IDictionary<string, string> query_map = null
                                    );
        Task<string> HttpGetStringAsync
                                    (
                                        string url,
                                        string query_url_encoded = null
                                    );

        Task<HttpWebResponse> HttpPostAsync
                                    (
                                        string url,
                                        IDictionary<string, string> data,
                                        IDictionary<string, string> headers = null
                                    );


    }
}
