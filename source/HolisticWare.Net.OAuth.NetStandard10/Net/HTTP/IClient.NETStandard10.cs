using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Net;

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// HTTP Client interface
    ///     Fluent interface
    ///     mimic CURL
    /// </summary>
    public partial interface IClient
    {
        Task<HttpWebResponse> HttpGetAsync
                                    (
                                        string url,
                                        IDictionary<string, string> query_map = null
                                    );

        Task<HttpWebResponse> HttpPostAsync
                                    (
                                        string url,
                                        IDictionary<string, string> data,
                                        IDictionary<string, string> headers = null
                                    );


    }
}
