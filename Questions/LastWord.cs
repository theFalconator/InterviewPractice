using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    public class LastWord
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var lastWord = s.Split(' ').Last();
            if (string.IsNullOrEmpty(lastWord))
                lastWord = s.Split(' ').Last();

            return string.IsNullOrEmpty(s) ? 0 : s.Split(' ').Last().Length;
        }
    }
}
