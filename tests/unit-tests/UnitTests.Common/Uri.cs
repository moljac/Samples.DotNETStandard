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

namespace NUnit.Tests.Net
{
    [TestFixture()]
    public partial class UriTests
    {
        [Test()]
        public void TestAbsoluteVSOriginal()
        {
            Uri uri_01 = new Uri("http://xamarin.com/");
            Uri uri_02 = new Uri("http://xamarin.com");

            Assert.AreEqual(uri_01, uri_02);

            if (uri_01 == uri_02)
            {
                Console.WriteLine(" uri_01 == uri_02");
            }

            Console.WriteLine($" uri_01.Absolute       = {uri_01.AbsoluteUri}");
            Console.WriteLine($" uri_02.Absolute       = {uri_02.AbsoluteUri}");
            Console.WriteLine($" uri_01.OriginalString = {uri_01.OriginalString}");
            Console.WriteLine($" uri_02.OriginalString = {uri_02.OriginalString}");

            /*
             uri_01 == uri_02
             uri_01.Absolute       = http://xamarin.com/
             uri_02.Absolute       = http://xamarin.com/
             uri_01.OriginalString = http://xamarin.com/
             uri_02.OriginalString = http://xamarin.com
            */  

            Assert.AreEqual(uri_01.AbsoluteUri, "http://xamarin.com/");
            Assert.AreEqual(uri_02.AbsoluteUri, "http://xamarin.com/");


            Assert.AreEqual(uri_01.OriginalString, "http://xamarin.com/");
            Assert.AreEqual(uri_02.OriginalString, "http://xamarin.com");

            return;
        }


    }
}
