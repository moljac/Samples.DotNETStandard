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
using System.Net.Http;

using HolisticWare.Net.HTTP;

using UnitTests.Common.Net.HTTP;

namespace NUnit.Tests.Net.HTTP
{
    [TestFixture()]
    public partial class ClientTests
    {
        [Test()]
        public void TestGetString()
        {
            Client c = new Client();
            Task<string> content = c.HttpGetStringAsync
                                        (
                                            $"{Data.UriAPIRequestBin}/{Data.IdRequestBin}",
                                            new Dictionary<string, string>
                                            {
                                                { "client_id", "client_id_obtained_string" },
                                                { "response_type", "code" },
                                                { "redirect_uri", "http://localhost" },
                                                { "scope", "" },
                                                { "state", "" },
                                            }
                                        );

            string s = content.Result;

            Console.WriteLine("Response: ");
            Console.WriteLine(s);

            return;
        }

        [Test()]
        public void TestGetWebResponse()
        {
            Client c = new Client();
            Task<HttpResponseMessage> content = c.HttpGetAsync
                                                    (
                                                        $"{Data.UriAPIRequestBin}/{Data.IdRequestBin}",
                                                        new Dictionary<string, string>
                                                        {
                                                            { "client_id", "client_id_obtained_string" },
                                                            { "response_type", "code" },
                                                            { "redirect_uri", "http://localhost" },
                                                            { "scope", "" },
                                                            { "state", "" },
                                                        }
                                                    );

            HttpResponseMessage r = content.Result;
            HttpContent http_content = r.Content;

            Console.WriteLine("Response: ");
            Console.WriteLine(http_content.ToString());

            return;
        }


    }
}
