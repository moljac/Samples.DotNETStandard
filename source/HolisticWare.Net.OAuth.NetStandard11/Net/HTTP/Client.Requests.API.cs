using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Http;
using System.IO;

using HolisticWare.Net;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
    {
        public Dictionary<Uri, ClientImplementation<HttpRequestMessage> > RequestImplementationObjects
        {
            get;
            set;
        } = null;

        public Dictionary<Uri, ClientImplementation<HttpResponseMessage>> ResponseImplementationObjects
        {
            get;
            set;
        } = null;
    }
} 
