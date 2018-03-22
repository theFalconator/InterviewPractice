using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    public class GroupingDishes
    {

        public string[][] groupingDishes(string[][] dishes)
        {
            // Build Dictionary of recipes and ingredients
            var dishesDict = new Dictionary<string, List<string>>();
            foreach (var dish in dishes)
            {
                // First element in dish is the recipe, other entries are ingredients
                // If the recipe is not in the dictionary add the key
                if (!dishesDict.ContainsKey(dish.First()))
                {
                    dishesDict.Add(dish.First(), dish.Skip(1).ToList());
                }
            }

            // Now use that dictionary to get a list of all ingredients
            var ingredients = dishesDict.SelectMany(i => i.Value);
            var ds = dishesDict.Keys.ToList();
         

            // "Invert" the dictionary from above
            var ingredientsDict = new Dictionary<string, List<string>>();
            foreach (var i in ingredients)
            {
                if (!ingredientsDict.ContainsKey(i))
                {
                    var dishesWithIngredient = new List<string>();
                    foreach (var d in ds)
                    {
                        if (dishesDict[d].Contains(i))
                        {
                            dishesWithIngredient.Add(d);
                        }
                    }
                    ingredientsDict.Add(i, dishesWithIngredient);
                }
            }

            // Convert ingredientsDict into string[][]
            return new string[2][];
        }
    }
}

