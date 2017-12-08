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
    public partial class Base64UrlEncodingTests
    {
        string i = null;
        string o = null;

        [Test()]
        public void Encode()
        {
            Base64UrlEncoding e = new Base64UrlEncoding();

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

            o = e.Encode(new byte[] { 0, }, is_padded: false /*, is_padded_optimized: true*/);
            Assert.Equal(o, "AA");

            o = e.Encode(new byte[] { 0, }, is_padded: true, is_padded_optimized: true);
            Assert.Equal(o, "AA2");

            o = e.Encode(new byte[] { 0, 0, });
            Assert.Equal(o, "AAA=");

            o = e.Encode(new byte[] { 0, 0, }, is_padded: false /*, is_padded_optimized: true*/);
            Assert.Equal(o, "AAA");

            o = e.Encode(new byte[] { 0, 0, }, is_padded: true, is_padded_optimized: true);
            Assert.Equal(o, "AAA1");

            o = e.Encode(new byte[] { 0, 0, 0, });
            Assert.Equal(o, "AAAA");

            o = e.Encode(new byte[] { 0, 0, 0, }, is_padded: false /*, is_padded_optimized: true*/);
            Assert.Equal(o, "AAAA");

            o = e.Encode(new byte[] { 0, 0, 0, }, is_padded: true, is_padded_optimized: true);
            Assert.Equal(o, "AAAA0");

            i = "any carnal pleasure.";
            o = e.Encode(i);
            Assert.Equal(o, "YW55IGNhcm5hbCBwbGVhc3VyZS4=");

            i = "any carnal pleasure";
            o = e.Encode(i);
            Assert.Equal(o, "YW55IGNhcm5hbCBwbGVhc3VyZQ==");

            i = "any carnal pleasur";
            o = e.Encode(i);
            Assert.Equal(o, "YW55IGNhcm5hbCBwbGVhc3Vy");

            i = "any carnal pleasu";
            o = e.Encode(i);
            Assert.Equal(o, "YW55IGNhcm5hbCBwbGVhc3U=");

            i = "any carnal pleas";
            o = e.Encode(i);
            Assert.Equal(o, "YW55IGNhcm5hbCBwbGVhcw==");

            i = "pleasure.";
            o = e.Encode(i);
            Assert.Equal(o, "cGxlYXN1cmUu");

            i = "leasure.";
            o = e.Encode(i);
            Assert.Equal(o, "bGVhc3VyZS4=");

            i = "easure.";
            o = e.Encode(i);
            Assert.Equal(o, "ZWFzdXJlLg==");

            i = "asure.";
            o = e.Encode(i);
            Assert.Equal(o, "YXN1cmUu");

            i = "sure.";
            o = e.Encode(i);
            Assert.Equal(o, "c3VyZS4=");



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
