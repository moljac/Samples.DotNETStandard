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
using System.Net;
using System.Json;
using System.Collections.Generic;

using Core.JSON.WebToken;

namespace NUnit.Tests.JSON
{
    public partial class JSONWebTokenTests
    {
        [Test()]
        public void TestEncode()
        {
            var secret_key = "secret";


            JSONWebToken jwt_object_01 = new JSONWebToken()
            {
                TokenData = new Data()
                {
                    Header = new Dictionary<string, string>()
                                        {
                                            { "alg", "HS256" },
                                            { "typ", "JWT" }

                                        },
                    Payload = new Dictionary<string, object>()
                                        {
                                            { "sub", 1234567890 },
                                            { "name", "John Doe" },
                                            { "admin", 1 },
                                            { "jti", "e0e56504-0060-434a-aaae-fc07c69be912" },
                                            { "iat", 1510316753 },
                                            { "exp", 1510320353 },
                                        },
                },
                Secret = secret_key,
            };

            string jwt_token = jwt_object_01.Encode();


            string token = 
                "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9"
                + "." + 
                "eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiYWRtaW4iOnRydWUsImp0aSI6ImUwZTU2NTA0LTAwNjAtNDM0YS1hYWFlLWZjMDdjNjliZTkxMiIsImlhdCI6MTUxMDMxNjc1MywiZXhwIjoxNTEwMzIwNDkxfQ"
                + "." + 
                "gqArrrW1oO8x6PwTeD2kHuujfNvk4uNx9Zbf0FAkZy0"
                ;

            string json = jwt_object_01.Decode(token, secret_key);

            return;
        }

        [Test()]
        public void TestDecode()
        {
            return;
        }
    }
}
