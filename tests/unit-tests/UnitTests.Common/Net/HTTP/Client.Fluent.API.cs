#if XUNIT
//https://xunit.github.io/docs/comparisons.html
using Xunit;

using Test              = Xunit.FactAttribute;

// Aliases
// dummy XUnit does need testFixture
using TestFixture       = System.ObsoleteAttribute;  
using TestFixtureSetUp  = System.ObsoleteAttribute;
#endif

#if NUNIT
using NUnit.Framework;
using Fact= NUnit.Framework.TestAttribute;
#endif

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using HolisticWare.Net.HTTP;

using UnitTests.Common.Net.HTTP;

namespace NUnit.Tests.Net.HTTP
{
    [TestFixture()]
    public partial class ClientTests
    {
        [Test()]
        public void Constructors()
        {
            Client c01 = new Client();

            return;
        }

        List<Client> Clients = null;

        [Test()]
        public void SetupUriEndpoints()
        {
            Clients = new List<Client>()
            {
                new Client()
                    .UrlEndpoint(Data.UriAPIs["RequestBin"])
                ,
                new Client()
                    .UrlEndpoint(Data.UriAPIs["RequestBin"]+ "?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoint(Data.UriAPIs["RequestBin"]+ "/api/demo?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoint(Data.UriAPIs["POST server"])
                ,
                new Client()
                    .UrlEndpoint(Data.UriAPIs["POST server"]+ "?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoint(Data.UriAPIs["POST server"]+ "/api/demo?name=user&date=2017-10-20")
                ,
                    new Client()
                    .UrlEndpoint(Data.UriAPIs["PutsReq"])
                ,
                new Client()
                    .UrlEndpoint(Data.UriAPIs["PutsReq"]+ "?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoint(Data.UriAPIs["PutsReq"]+ "/api/demo?name=user&date=2017-10-20")




                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["RequestBin"] + " " + Data.UriAPIs["PutsReq"])
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["RequestBin"]+ "?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["RequestBin"]+ "/api/demo?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["POST server"])
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["POST server"]+ "?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["POST server"]+ "/api/demo?name=user&date=2017-10-20")
                ,
                    new Client()
                    .UrlEndpoints(Data.UriAPIs["PutsReq"])
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["PutsReq"]+ "?name=user&date=2017-10-20")
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["PutsReq"]+ "/api/demo?name=user&date=2017-10-20")
                ,
            };

            foreach(Client c in Clients)
            {
                // Dumping
                //  Abstraction API (HTTP.Client)
                //  Implementation API
                //      .NET Standard 1.0 - HttpWebRequest
                //      .NET Standard 1.1 - HttpClient
                //  Raw HTTP request
                string client_dump = c.ToString("A I R");

                Console.WriteLine($"{client_dump}");
            }

            return;
        }

        [Test()]
        public void SetupMethods()
        {
            Clients = new List<Client>()
            {
                new Client()
                    .UrlEndpoints(Data.UriAPIs["RequestBin"] + " " + Data.UriAPIs["PutsReq"])
                    .Method("POST")
                ,
                new Client()
                    .UrlEndpoints(Data.UriAPIs["RequestBin"]+ "?name=user&date=2017-10-20")
                    .Method("POST")
                ,
            };

            foreach(Client c in Clients)
            {
                // Dumping
                //  Abstraction API (HTTP.Client)
                //  Implementation API
                //      .NET Standard 1.0 - HttpWebRequest
                //      .NET Standard 1.1 - HttpClient
                //  Raw HTTP request
                string client_dump = c.ToString("A I R");

                Console.WriteLine($"{client_dump}");
            }

            return;
        }

        [Test()]
        public void SetupHeaders()
        {
            List<Client> clients = new List<Client>()
            {
                new Client()
                    .UrlEndpoint("http://xamarin.com http://example.com")
                    .Headers
                            (
                                new List<string>()
                                {
                                    "Accept: text/plain",
                                    "Accept:text/plain",        // TODO: check correctness
                                }
                            )
                    ,
            };

            foreach (Client c in clients)
            {
                // Dumping
                //  Abstraction API (HTTP.Client)
                //  Implementation API
                //      .NET Standard 1.0 - HttpWebRequest
                //      .NET Standard 1.1 - HttpClient
                //  Raw HTTP request
                string client_dump = c.ToString("A I R");

                Console.WriteLine($"{client_dump}");
            }

            return;
        }
    }
}
