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

            byte[] bytes01      = rd.ComputeSHA256Hash("moljac");
            string sha01        = "B5E6408E176915DA9D40CE5652BC46B8E07A3E8F66289FAFFA641BB39F057B3B";
            byte[] sha_bytes_01 = System.Text.Encoding.ASCII.GetBytes(sha01);
            Assert.AreEqual(bytes01, sha_bytes_01);

            string str01 = rd.Base64UrlEncodeNoPadding(bytes01);

            return;
        }

    }
}
