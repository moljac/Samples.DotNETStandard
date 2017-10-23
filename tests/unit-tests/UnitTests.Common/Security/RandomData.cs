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

namespace NUnit.Tests.Net
{
    [TestFixture()]
    public partial class RandomDataTests
    {
        [Test()]
        public void RandomStringSimple()
        {
            RandomData rd = new RandomData();

            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 100; i++)
                {
                    string random_string = rd.RandomString((ulong)(4 * j));
                    Console.WriteLine($" random_string = {random_string}");

                    Assert.AreEqual(random_string.Length, 4 * j);
                }
            }

            return;
        }

    }
}
