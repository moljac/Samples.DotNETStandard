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
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;

using HolisticWare.Net.Http;
using Xamarin.Auth.OAuth2;

namespace NUnit.Tests
{
    [TestFixture()]
    public class StateTests
    {
        [Test()]
        public void TestGetString()
        {
            State state = new State();

            string uri_request_token = "";
            string data_body_token_request = "";


            return;
        }

        public async Task OAuthPostAsync
                                (
                                    string uri_request_token,
                                    string data_body_token_request,
                                    string content_type = "application/x-www-form-urlencoded",
                                    string accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
                                )
        {
            HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create(uri_request_token);
            tokenRequest.Method = "POST";
            tokenRequest.ContentType = content_type;
            tokenRequest.Accept = accept;

            byte[] bytes = null;

            //bytes = Encoding.ASCII.GetBytes(data_body_token_request);
            bytes = Encoding.UTF8.GetBytes(data_body_token_request);

            tokenRequest.ContentLength = bytes.Length;
            using (Stream stream = tokenRequest.GetRequestStream())
            {
                await stream.WriteAsync(bytes, 0, bytes.Length);
                stream.Close();
            }

            return;
        }

    }
}
