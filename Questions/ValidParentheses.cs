using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            var opening = new[] {"(", "[", "{"};

            if (s.Length == 1 && !opening.Any(s.Contains))
                return false;

            Stack<char> closingStack = new Stack<char>();
            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        closingStack.Push(')');
                        break;
                    case '[':
                        closingStack.Push(']');
                        break;
                    case '{':
                        closingStack.Push('}');
                        break;
                    default:
                        if (closingStack.Count == 0)
                            return false;
                        if (c != closingStack.Peek())
                            return false;

                        closingStack.Pop();
                        break;
                }
            }
            return closingStack.Count == 0;
        }
    }
}
