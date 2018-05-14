using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    public class IntegerToRoman
    {
        public string intToRoman(int num)
        {

            var numerals = new Dictionary<string, int>
            {
                {"I", 1},
                {"IV", 4},
                {"V", 5},
                {"IX", 9},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000}
            };

            var result = new StringBuilder();

            while (num > 0)
            {
                var kvp = numerals
                    .Where(n => n.Value <= num)
                    .OrderBy(n => n.Value)
                    .Last();
                num -= kvp.Value;
                result.Append(kvp.Key);
            }

            return result.ToString();
        }
    }
}
