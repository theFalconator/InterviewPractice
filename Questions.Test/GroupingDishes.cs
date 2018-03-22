using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class GroupingDishes
    {
        [Fact]
        public void SplitInputStringIntoKeyAndValues()
        {
            // Arrange
            var gd = new Questions.GroupingDishes();
            string[][] dishes = {new[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"}};
            // Act
            var key = dishes.First().First();
            var values = dishes.First().Skip(1);
            gd.groupingDishes(dishes);
            // Assert
            Assert.Equal("Salad", key);
            Assert.Equal(new[] {"Tomato", "Cucumber", "Salad", "Sauce"}, values);
        }
    }

}
