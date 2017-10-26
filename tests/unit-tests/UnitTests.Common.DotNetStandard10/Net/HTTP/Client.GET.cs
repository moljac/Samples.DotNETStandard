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
using System.Net;

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

            foreach (KeyValuePair<string, string> kvp in Data.UriAPIs)
            {
                
                string endpoint = kvp.Value;

                Console.WriteLine($"Endpoint: {endpoint}");

                try
                {
                    Task<string> content = c.HttpGetStringAsync
                                                    (
                                                        endpoint,
                                                        new Dictionary<string, string>
                                                        {
                                                        { "client_id", "client_id_obtained_string" },
                                                        { "response_type", "code" },
                                                        { "redirect_uri", "http://localhost" },
                                                        { "scope", "unit test client.HttpGetStringAsync()" },
                                                        { "state", "" },
                                                        }
                                                    );

                    string s = content.Result;

                    Console.WriteLine("Response: ");
                    Console.WriteLine(s);
                }
                catch (AggregateException exc_agg)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($" message  = {exc_agg.Message}");
                    sb.AppendLine($" endpoint = {endpoint}");

                    Console.WriteLine(sb.ToString());
                }
            }

            return;
        }


        [Test()]
        public void TestGetWebResponse()
        {
            Client c = new Client();

            foreach (KeyValuePair<string, string> kvp in Data.UriAPIs)
            {

                string endpoint = kvp.Value;

                Console.WriteLine($"Endpoint: {endpoint}");

                try
                {

                    Task<HttpWebResponse> content = c.HttpGetAsync
                                                            (
                                                                endpoint,
                                                                new Dictionary<string, string>
                                                                {
                                                                { "client_id", "client_id_obtained_string" },
                                                                { "response_type", "code" },
                                                                { "redirect_uri", "http://localhost" },
                                                                { "scope", "unit test client.HttpGetAsync()" },
                                                                { "state", "" },
                                                                }
                                                            );

                    HttpWebResponse r = content.Result;

                    Console.WriteLine("Response: ");
                    Console.WriteLine(r.Cookies.ToString());
                }
                catch(AggregateException exc_agg)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($" message  = {exc_agg.Message}");
                    sb.AppendLine($" endpoint = {endpoint}");

                    Console.WriteLine(sb.ToString());
                }
            }

            return;
        }

    }
}
