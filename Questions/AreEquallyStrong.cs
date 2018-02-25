using System;
using System.Linq;

namespace Questions
{
    public class AreEquallyStrong
    {
        public bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            var yours = new[] {yourLeft, yourRight};
            var theirs = new[] {friendsLeft, friendsRight};

            return yours.Max() == theirs.Max() && yours.Min() == theirs.Min();
        }
    }
}
