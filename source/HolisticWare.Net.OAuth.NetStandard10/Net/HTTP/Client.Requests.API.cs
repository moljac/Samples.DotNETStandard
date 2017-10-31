using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

using HolisticWare.Net;
using System.Linq;

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// Client for HTTP Requests
    /// .NET Standard 1.0 implementation with HttpWebRequest and HttpWebResponse
    /// </summary>
    public partial class Client : IClient
    {
        public Dictionary<Uri, ClientImplementation<HttpWebRequest>>  RequestImplementationObjects
        {
            get;
            set;
        } = null;

        public Dictionary<Uri, ClientImplementation<HttpWebResponse>> ResponseImplementationObjects
        {
            get;
            set;
        } = null;

        //System.Net.WebRequest web_request = null;
        //System.Net.HttpRequestHeader http_request_header;
    }
} 
