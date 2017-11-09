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
    [TestFixture()]
    public partial class JSONWebTokenTests
    {
        [Test()]
        public void TestParse()
        {
            // https://jwt.io/

            JSONWebToken jwt_object_01 = new JSONWebToken()
            {
                Header = new Dictionary<string, string>()
                {
                    { "alg", "HS256" },
                    { "typ", "JWT" }

                },
                Payload = new Dictionary<string, object>()
                {
                    { "claim1", 0 },
                    { "claim2", "claim2-value" }

                },
                Secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk",
            };

            string jwt_token = jwt_object_01.Encode();

            //var token = encoder.Encode(payload, secret);
            //Console.WriteLine(token);           


            var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJjbGFpbTEiOjAsImNsYWltMiI6ImNsYWltMi12YWx1ZSJ9.8pwBI_HtXqI3UgQHQ_rDRnSQRxFL1SR8fbQoS-5kM5s";
            var secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";
            //try
            //{
            //    IJsonSerializer serializer = new JsonNetSerializer();
            //    IDateTimeProvider provider = new UtcDateTimeProvider();
            //    IJwtValidator validator = new JwtValidator(serializer, provider);
            //    IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            //    IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);

            //    var json = decoder.Decode(token, secret, verify: true);

            //    { "claim1": 0, "claim2": "claim2-value" }

            //    Console.WriteLine(json);
            //}
            //catch (TokenExpiredException)
            //{
            //    Console.WriteLine("Token has expired");
            //}
            //catch (SignatureVerificationException)
            //{
            //    Console.WriteLine("Token has invalid signature");
            //}

            return;
        }


    }
}
