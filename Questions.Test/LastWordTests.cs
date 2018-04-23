using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class LastWordTests
    {
        [Fact]
        public void HelloWorldShouldReturn5()
        {
            var lw = new LastWord();

            Assert.Equal(5, lw.LengthOfLastWord("Hello World"));
        }

        [Fact]
        public void EmptyOrNullShouldReturn0()
        {
            var lw = new LastWord();

            Assert.Equal(0, lw.LengthOfLastWord(""));
            Assert.Equal(0, lw.LengthOfLastWord(null));
        }

        [Fact]
        public void NoWordAfterLastSpaceShouldReturnNextToLastWord()
        {
            var lw = new LastWord();

            Assert.Equal(1, lw.LengthOfLastWord("a "));
        }
    }
}
