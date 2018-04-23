using System;
using System.Collections.Generic;
using System.Text;

namespace Questions
{
    public class LongestCommonSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var map = new Dictionary<char, int>();
            var max = 0;
            var j = 0;
            for (var i = 0; i < s.Length; i++)
            {
                
                if (map.ContainsKey(s[i]))
                {
                    j = Math.Max(j, map[s[i]] + 1);
                    map[s[i]] = i;
                }
                else
                {
                    map.Add(s[i], i);
                }
                
                
                max = Math.Max(max, i - j + 1);
            }

            return max;

        }
    }
}
