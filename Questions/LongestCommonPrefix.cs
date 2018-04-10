using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    public class LongestCommonPrefix
    {
        public string longestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            var sortedStrings = strs.OrderBy(x => x.Length).ToArray();
            string prefix = "";
            for (int i = 0; i < sortedStrings.First().Length; i++)
            {
                if (i > 0 && string.IsNullOrEmpty(prefix))
                    return "";

                if (sortedStrings.All(s => s[i] == sortedStrings.First()[i]))
                    prefix += sortedStrings.First()[i];

            }

            return prefix;
        }
    }
}
