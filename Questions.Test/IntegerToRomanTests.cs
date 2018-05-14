using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class IntegerToRomanTests
    {
        [Fact]
        public void BasicTen()
        {
            var itor = new IntegerToRoman();
            Assert.Equal("I", itor.intToRoman(1));
            Assert.Equal("II", itor.intToRoman(2));
            Assert.Equal("III", itor.intToRoman(3));
            Assert.Equal("IV", itor.intToRoman(4));
            Assert.Equal("V", itor.intToRoman(5));
            Assert.Equal("VI", itor.intToRoman(6));
            Assert.Equal("VII", itor.intToRoman(7));
            Assert.Equal("VIII", itor.intToRoman(8));
            Assert.Equal("IX", itor.intToRoman(9));
            Assert.Equal("X", itor.intToRoman(10));
        }

        [Fact]
        public void Teens()
        {
            var itor = new IntegerToRoman();
            Assert.Equal("XIV", itor.intToRoman(14));
            Assert.Equal("XIX", itor.intToRoman(19));
        }
    }
}
