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
using HolisticWare.Security;

namespace NUnit.Tests.Security
{
    [TestFixture()]
    public partial class RandomDataTests
    {
        [Test()]
        public void RandomStringSimple()
        {
            RandomData rd = new RandomData();

            // http://passwordsgenerator.net/sha256-hash-generator/
            //      sha256(moljac)          =   B5E6408E176915DA9D40CE5652BC46B8E07A3E8F66289FAFFA641BB39F057B3B
            // http://www.xorbin.com/tools/sha256-hash-calculator
            //      sha256(moljac)          =   b5e6408e176915da9d40ce5652bc46b8e07a3e8f66289faffa641bb39f057b3b

            // http://www.miraclesalad.com/webtools/sha256.php

            // https://www.online-convert.com/result/2d9b5329-81bc-47cd-830e-22858c41d992
            //      hex:    sha256(moljac)  =   b5e6408e176915da9d40ce5652bc46b8e07a3e8f66289faffa641bb39f057b3b
            //      HEX:    sha256(moljac)  =   B5E6408E176915DA9D40CE5652BC46B8E07A3E8F66289FAFFA641BB39F057B3B
            //      h:e: x: sha256(moljac)  =   b5: e6: 40:8e:17:69:15:da: 9d:40:ce: 56:52:bc: 46:b8: e0: 7a: 3e:8f:66:28:9f:af: fa: 64:1b: b3: 9f:05:7b: 3b
            //      base64: sha256(moljac)  =   teZAjhdpFdqdQM5WUrxGuOB6Po9mKJ + v + mQbs58Fezs =
                
            byte[] bytes01      = rd.ComputeSHA256Hash("moljac");
            string sha01        = "B5E6408E176915DA9D40CE5652BC46B8E07A3E8F66289FAFFA641BB39F057B3B";

            byte[] sha_bytes_01 = System.Text.Encoding.ASCII.GetBytes(sha01);
            //Assert.AreEqual(bytes01, sha_bytes_01);

            string str01 = rd.Base64UrlEncodeNoPadding(bytes01);

            return;
        }

    }
}
