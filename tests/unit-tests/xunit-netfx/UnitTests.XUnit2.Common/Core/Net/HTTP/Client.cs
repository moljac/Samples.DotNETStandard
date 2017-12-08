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

using Core.Net.HTTP;

namespace NUnit.Tests.Net.HTTP
{
    public partial class ClientTests
    {
        [Test()]
        public void TestConstructors()
        {
            Client c = new Client();

            return;
        }


        public void Save(string[] filepath, string content)
        {
            string path = System.IO.Path.Combine(filepath);

            System.IO.File.WriteAllText(path, content);

            return;
        }


    }
}
