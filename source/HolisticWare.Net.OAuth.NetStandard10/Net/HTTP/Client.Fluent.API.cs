using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using System.Net;
using System.Text;

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// HTTP Client
    /// .NET Standard 1.0 
    /// implemented with
    ///         HttpWebRequest  (WebRequest) 
    ///         HttpWebResponse (WebResponse) 
    /// </summary>
    public partial class Client : IClient, IFormattable
    {
        public Client UrlEndpoint(Uri url)
        {
            if (null == url)
            {
                throw new ArgumentException("url");
            }

            if (null == this.EndPoints)
            {
                this.EndPoints = new List<Uri>();
            }

            if (null == this.RequestImplementationObjects)
            {
                this.RequestImplementationObjects = new Dictionary<Uri, ClientImplementation<HttpWebRequest>>();
            }

            this.EndPoints.Add(url);
            this.RequestImplementationObjects.Add(url, (HttpWebRequest)WebRequest.Create(url));

            return this;
        }
    }
} 
