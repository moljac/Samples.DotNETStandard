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
using System.Net;
using System.Text;

using HolisticWare.Net.HTTP;

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


        [Test()]
        public void SetupUriEndpoints()
        {
            List<Client> clients = new List<Client>()
            {
                new Client()
                    .UrlEndpoint("http://xamarin.com")
                ,
                new Client()
                    .UrlEndpoint("http://xamarin.com?name=user&date=2017-10-20")
                ,
                 new Client()
                        .UrlEndpoints("http://xamarin.com")
                ,
                new Client()
                        .UrlEndpoints("http://xamarin.com; https://example.com")
                ,
                new Client()
                        .UrlEndpoints("http://xamarin.com;https://example.com")
                ,
                new Client()
                        .UrlEndpoints("http://xamarin.com https://example.com")
                ,
                new Client()
                    .UrlEndpoint("http://xamarin.com?name=user&date=2017-10-20")
                ,
            };

            foreach(Client c in clients)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("-------------------------------------------------------------------");
                foreach(Uri uro in c.EndPoints)
                {
                    sb.AppendLine($"Uri = {c.EndPoints}");
                }
                sb.AppendLine("-------------------------------------------------------------------");
            }
        }

        [Test()]
        public void SetupMethods()
        {
            List<Client> clients = new List<Client>()
            {
                new Client()
                    .UrlEndpoint("http://xamarin.com http://example.com")
                    ,
            };

            foreach(Client c in clients)
            {
                
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
                                    "Accept:text/plain",
                                }
                            )
                    ,
            };

            foreach (Client c in clients)
            {

            }

            return;
        }
    }
}
