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

using HolisticWare.Net.HTTP;

namespace NUnit.Tests.Net.HTTP
{
    [TestFixture()]
    public partial class QueryParametersTests
    {
        [Test()]
        public void Constructors()
        {
            QueryParameters query01 = new QueryParameters();

            Console.WriteLine($"query01                 = {query01}");
            Console.WriteLine($"query01.ToString()      = {query01.ToString()}");
            Console.WriteLine($"query01.ToString(\"D\") = {query01.ToString("D")}");
            Console.WriteLine($"query01.ToString(\"F\") = {query01.ToString("F")}");
            Console.WriteLine($"query01.ToString(\"Q\") = {query01.ToString("Q")}");

            Dictionary<string, string> oauth_authorization = new Dictionary<string, string>()
            {
                { "client_id", "client_id_obtained_string" },
                { "response_type", "code" },
                { "redirect_uri", "http://localhost" },
                { "scope", "" },
                { "state", "" },
            };

            QueryParameters query02 = new QueryParameters(oauth_authorization);

            Console.WriteLine($"query02                 = {query02}");
            Console.WriteLine($"query02.ToString()      = {query02.ToString()}");
            Console.WriteLine($"query02.ToString(\"D\") = {query02.ToString("D")}");
            Console.WriteLine($"query02.ToString(\"F\") = {query02.ToString("F")}");
            Console.WriteLine($"query02.ToString(\"Q\") = {query02.ToString("Q")}");

            return;
        }


        [Test()]
        public void Merge()
        {
            Dictionary<string, string> qp01 = new Dictionary<string, string>()
            {
                { "client_id", "client_id_obtained_string" },
                { "response_type", "code-old" },
                { "redirect_uri", "http://localhost" },
            };

            QueryParameters query01 = new QueryParameters(qp01);

            Console.WriteLine($"query01.ToString(\"D\") = {query01.ToString("D")}");

            Dictionary<string, string> qp02 = new Dictionary<string, string>()
            {
                { "response_type", "code" },
                { "redirect_uri", "http://localhost" },
                { "scope", "" },
                { "state", "" },
            };

            Dictionary<string, string> qp03 = query01.Merge(qp02);

            Console.WriteLine($"query01.ToString(\"D\") = {query01.ToString("D")}");

        }

    }
}
