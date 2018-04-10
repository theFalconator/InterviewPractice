using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class LongestCommonPrefixTests
    {
        [Fact]
        public void StringsCanShareCommonPrefix()
        {
            var input = new[] {"aab", "aabcd"};
            var lcp = new LongestCommonPrefix();
            Assert.Equal("aab", lcp.longestCommonPrefix(input));
        }

        [Fact]
        public void NoCommonPrefixReturnsEmptyString()
        {
            var input = new[] {"cat", "bat", "hat"};
            var lcp = new LongestCommonPrefix();
            Assert.Equal("", lcp.longestCommonPrefix(input));
        }

        [Fact]
        public void ReturnsEmptyStringForNoInput()
        {
            var lcp = new LongestCommonPrefix();
            Assert.Equal("", lcp.longestCommonPrefix(null));
        }
    }
}
