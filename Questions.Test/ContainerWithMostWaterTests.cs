using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Questions.Test
{
    public class ContainerWithMostWaterTests
    {
        private readonly ITestOutputHelper output;

        public ContainerWithMostWaterTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void NotEnoughLinesReturnsNegativeOne()
        {
            var container = new ContainerWithMostWater();
            var lines = new[] {1};
            Assert.Equal(-1, container.MaxArea(lines));
        }

        [Fact]
        public void OnlyTwoLinesReturnsArea()
        {
            var container = new ContainerWithMostWater();
            var lines = new[] {1, 3};
            Assert.Equal(1, container.MaxArea(lines));
        }

        [Fact]
        public void SampleInputShouldReturn49()
        {
            var sw = new Stopwatch();
            
            var container = new ContainerWithMostWater();

            var lines = new[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            
            Assert.Equal(49, container.MaxArea(lines));
        }
    }
}
