using System;
using Xunit;

namespace Questions.Test
{
    public class areEquallyStrong
    {
        [Fact]
        public void EqualButOpposite()
        {
            var strong = new AreEquallyStrong();

            Assert.True(strong.areEquallyStrong(10,15,15,10));
        }

        [Fact]
        public void NotEqual()
        {
            var strong = new AreEquallyStrong();

            Assert.False(strong.areEquallyStrong(15,10,15,9));
        }
    }
}
