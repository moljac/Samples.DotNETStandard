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
        Client UrlEndpoints(string url);

        Client UrlEndpoints(IEnumerable<Uri> urls);

        Client UrlEndpoint(Uri url);

        Client Method(string method);

        Client Headers(List<string> headers);

        Client Headers(IDictionary<string, string> headers);

        Client Parameters(IDictionary<string, string> parameters);

        Client ParameterEncodings(IDictionary<string, Func<string, string> > parameters);

    }
}
