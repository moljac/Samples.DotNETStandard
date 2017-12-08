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
using Core.Text.Encodings;

namespace NUnit.Tests.Text.Encodings
{
    public partial class Base64EncodingTests
    {
        string i = null;
        string o = null;

        [Test()]
        public void Encode()
        {
            Base64Encoding e = new Base64Encoding();

            i = "test";
            o = e.Encode(i);
            Assert.Equal(o, "dGVzdA==");

            i = "test0";
            o = e.Encode(i);
            Assert.Equal(o, "dGVzdDA=");

            i = "test00";
            o = e.Encode(i);
            Assert.Equal(o, "dGVzdDAw");

            i = "test01";
            o = e.Encode(i);
            Assert.Equal(o, "dGVzdDAx");

            i = "test000";
            o = e.Encode(i);
            Assert.Equal(o, "dGVzdDAwMA==");

            o = e.Encode(new byte[] { 0, });
            Assert.Equal(o, "AA==");

            o = e.Encode(new byte[] { 0, 0, });
            Assert.Equal(o, "AAA=");

            o = e.Encode(new byte[] { 0, 0, 0, });
            Assert.Equal(o, "AAAA");

            i =
                "Man is distinguished, not only by his reason, but by this singular passion from "
                +
                "other animals, which is a lust of the mind, that by a perseverance of delight "
                + 
                "in the continued and indefatigable generation of knowledge, exceeds the short"
                + 
                "vehemence of any carnal pleasure."
                ;
            string o_encoded =
                "TWFuIGlzIGRpc3Rpbmd1aXNoZWQsIG5vdCBvbmx5IGJ5IGhpcyByZWFzb24sIGJ1dCBieSB0aGlz"
                +
                "IHNpbmd1bGFyIHBhc3Npb24gZnJvbSBvdGhlciBhbmltYWxzLCB3aGljaCBpcyBhIGx1c3Qgb2Yg"
                +
                "dGhlIG1pbmQsIHRoYXQgYnkgYSBwZXJzZXZlcmFuY2Ugb2YgZGVsaWdodCBpbiB0aGUgY29udGlu"
                +
                "dWVkIGFuZCBpbmRlZmF0aWdhYmxlIGdlbmVyYXRpb24gb2Yga25vd2xlZGdlLCBleGNlZWRzIHRo"
                +
                "ZSBzaG9ydCB2ZWhlbWVuY2Ugb2YgYW55IGNhcm5hbCBwbGVhc3VyZS4="
                ;

            o = e.Encode(i);
            //Assert.Equal(o, o_encoded);

            return;
        }

        [Test()]
        public void Decode()
        {
            Base64Encoding e = new Base64Encoding();

            i = "dGVzdA==";
            o = e.DecodeAsString(i);
            Assert.Equal(o, "test");

            i = "dGVzdDA=";
            o = e.DecodeAsString(i);
            Assert.Equal(o, "test0");

            i = "dGVzdDAw";
            o = e.DecodeAsString(i);
            Assert.Equal(o, "test00");

            i = "dGVzdDAx";
            o = e.DecodeAsString(i);
            Assert.Equal(o, "test01");

            i = "dGVzdDAwMA==";
            o = e.DecodeAsString(i);
            Assert.Equal(o, "test000");

            byte[] bytes = null;

            bytes  = e.Decode("AA==");
            Assert.Equal(bytes, new byte[]{ 0, });

            bytes = e.Decode("AAA=");
            Assert.Equal(bytes, new byte[] { 0, 0, });

            bytes = e.Decode("AAAA");
            Assert.Equal(bytes, new byte[] { 0, 0, 0, });


            return;
        }

    }
}
