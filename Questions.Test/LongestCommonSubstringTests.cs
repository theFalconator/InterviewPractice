using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class LongestCommonSubstringTests
    {
        [Fact]
        public void EmptyStringsReturnZero()
        {
            var lcs = new LongestCommonSubstring();

            Assert.Equal(0, lcs.LengthOfLongestSubstring(""));
        }

        [Fact]
        public void CanFindSubstringAtBeginning()
        {
            var input = "abcabcbb";
            var expected = "abc";

            var lcs = new LongestCommonSubstring();

            Assert.Equal(expected.Length, lcs.LengthOfLongestSubstring(input));
        }

        [Fact]
        public void CanFindSubstringInMiddle()
        {
            var input = "pwwkew";
            var expected = "wke";

            var lcs = new LongestCommonSubstring();

            Assert.Equal(expected.Length, lcs.LengthOfLongestSubstring(input));
        }
    }
}
