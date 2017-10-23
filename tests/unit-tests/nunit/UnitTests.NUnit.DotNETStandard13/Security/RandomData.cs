﻿#if XUNIT
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

            return;
        }

    }
}
