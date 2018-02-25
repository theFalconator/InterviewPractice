using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class MaximalAdjDiff
    {
        [Fact]
        public void SampleTest()
        {
            var input = new[] {2, 4, 1, 0};
            var diff = new MaximalAdjacentDifference();
            Assert.Equal(3, diff.arrayMaximalAdjacentDifferrence(input));
        }
    }
}
