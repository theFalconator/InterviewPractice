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
            // string[][] dishes = {new[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"}};
            string[][] dishes =
            {
                    new[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"},
                    new[] {"Pizza", "Tomato", "Sausage", "Sauce", "Dough"},
                    new[] {"Quesadilla", "Chicken", "Cheese", "Sauce"},
                    new[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            // Act
            var key = dishes.First().First();
            var values = dishes.First().Skip(1);
            gd.groupingDishes(dishes);
            // Assert
            Assert.Equal("Salad", key);
            Assert.Equal(new[] {"Tomato", "Cucumber", "Salad", "Sauce"}, values);
        }

        [Fact]
        public void CommonIngredientsBecomeKeys()
        {
            // Arrange
            var gd = new Questions.GroupingDishes();
            
            string[][] dishes =
            {
                new[] {"Salad", "Tomato", "Blah"},
                new[] {"Pizza", "Tomato", "Sauce", "Dough"},
            };

            // Act
            string[][] result = gd.groupingDishes(dishes);
            
            // Assert
            Assert.Equal("Tomato", result[0][0]);
        }

        [Fact]
        public void TestCase1()
        {
            // Arrange
            var gd = new Questions.GroupingDishes();
            // string[][] dishes = {new[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"}};
            string[][] dishes =
            {
                new[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"},
                new[] {"Pizza", "Tomato", "Sausage", "Sauce", "Dough"},
                new[] {"Quesadilla", "Chicken", "Cheese", "Sauce"},
                new[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" }
            };

            var result = gd.groupingDishes(dishes);

            Assert.Equal("Cheese", result[0][0]);
            Assert.Equal("Salad", result[1][0]);
            Assert.Equal("Sauce", result[2][0]);
            Assert.Equal("Tomato", result[3][0]);
        }
        

    }

}
