using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData("()")]
        [InlineData("[]")]
        [InlineData("{}")]
        public void SingleBracketTypeClosesCorrectly(string parens)
        {
            var vp = new ValidParentheses();

            Assert.True(vp.IsValid(parens));
        }

        [Theory]
        [InlineData("()[]{}")]
        [InlineData("([{}])")]
        public void BracketsCloseInCorrectOrder(string parens)
        {
            var vp = new ValidParentheses();

            Assert.True(vp.IsValid(parens));
        }

        [Theory]
        [InlineData("(]")]
        [InlineData("([)]")]
        public void BracketsClosingInWrongOrderShouldReturnFalse(string parens)
        {
            var vp = new ValidParentheses();

            Assert.False(vp.IsValid(parens));
        }

        [Fact]
        public void DoesntTryToPopAnEmptyStack()
        {
            var vp = new ValidParentheses();

            // Assert.False(vp.IsValid("]"));
            Assert.False(vp.IsValid("){"));
        }
    }
}
