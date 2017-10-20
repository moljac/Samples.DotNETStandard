using System;
using System.Threading.Tasks;

using NUnit.Framework;

using ClassesToTest.Shared.DotNetStandard1_0;

namespace NUnit.Tests
{
    [TestFixture()]
    public class TestOAuth2Http
    {
        [Test()]
        public void TestCase()
        {
            OAuth2Http oauth2 = new OAuth2Http();
            Task<string> content = oauth2.HttpGetAsync("http://xamarin.com");

            string s = content.Result;

            return;
        }
    }
}
