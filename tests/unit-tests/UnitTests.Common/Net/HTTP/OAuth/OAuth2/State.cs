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
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;

using HolisticWare.Net.HTTP.OAuth.OAuth2;

namespace NUnit.Tests.Net.HTTP.OAuth.OAuth2
{
    [TestFixture()]
    public class StateTests
    {
        [Test()]
        public void TestGetString()
        {
            State state_object = new State();

            string state01 = state_object.GenerateOAuth2StateRandom();
            string state02 = state_object.GenerateOAuth2StateRandom(16);
            string state03 = state_object.GenerateOAuth2StateRandom(32);
            string state04 = state_object.GenerateOAuth2StateRandom(64);

            Console.WriteLine($" state01 = {state01}");
            Console.WriteLine($" state02 = {state02}");
            Console.WriteLine($" state03 = {state03}");
            Console.WriteLine($" state04 = {state04}");

            return;
        }

    }
}
