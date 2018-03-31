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

                    if(dishesWithIngredient.Count >= 2)
                        ingredientsDict.Add(i, dishesWithIngredient);
                }
            }

            // Convert ingredientsDict into string[][]
            var keys = ingredientsDict.Keys.ToList();
            var l = new List<List<string>>();
            foreach (var k in keys)
            {
                var t = new List<string>();

                foreach (var i in ingredientsDict[k])
                {
                    t.Add(i);
                }

                t.Sort();
                t.Insert(0,k);
                l.Add(t);
            }

            return l
                .Select(a=>a.ToArray())
                .OrderBy(i=>i[0])
                .ToArray();
        }
    }
}



