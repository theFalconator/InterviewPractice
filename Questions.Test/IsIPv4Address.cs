using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class IsIPv4Address
    {
        [Fact]
        public void AllNumbersMustBeBetween0And255()
        {
            var ip = new IPv4();
            const string input = "172.16.254.1";
            const string fails = "256.1.1.2";
            Assert.True(ip.isIPv4Address(input));
            Assert.False(ip.isIPv4Address(fails));
        }

        [Fact]
        public void ShouldOnlyBeThreeDots()
        {
            var ip = new IPv4();
            const string input = "172.16.254.1";
            const string fails = "172.16.254.1.2";
            Assert.True(ip.isIPv4Address(input));
            Assert.False(ip.isIPv4Address(fails));
        }

        [Fact]
        public void ShouldHaveFourNumbers()
        {
            var ip = new IPv4();
            const string input = ".16.254.1";
            Assert.False(ip.isIPv4Address(input));
        }

        [Fact]
        public void BoundsCheck()
        {
            var ip = new IPv4();
            const string input = "0.254.255.0";
            Assert.True(ip.isIPv4Address(input));
        }

    }
}
