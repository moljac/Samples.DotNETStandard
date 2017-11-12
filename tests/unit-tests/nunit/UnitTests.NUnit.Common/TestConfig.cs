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
using Fact = NUnit.Framework.TestAttribute;
#endif

using System;

namespace UnitTests.Common
{
    [SetUpFixture]
    public class TestConfig
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            var dir = System.IO.Path.GetDirectoryName(typeof(TestConfig).Assembly.Location);
            Environment.CurrentDirectory = dir;

            // or
            System.IO.Directory.SetCurrentDirectory(dir);

            return;
        }
    }}
