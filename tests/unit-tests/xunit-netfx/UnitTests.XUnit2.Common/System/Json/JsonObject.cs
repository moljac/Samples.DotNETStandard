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

namespace NUnit.Tests.JSON
{
    public partial class JsonObjectTests
    {
        [Test()]
        public void TestParse()
        {   
            string json = @"{""simple"":""value1"",""complex"":{""name"":""value2"",""id"":""value3""}}";


            JsonValue jv = JsonValue.Parse(json);

            string simple_value = jv["simple"];      // contains "value1"

            Assert.Equal(simple_value, "value1");

            JsonValue complex = jv["complex"];
            string name_value = complex["name"];     // contains "value2"

            Assert.Equal(name_value, "value2");

            string id_value = complex["id"];     // contains "value2"

            Assert.Equal(id_value, "value3");
           return;
        }


    }
}
