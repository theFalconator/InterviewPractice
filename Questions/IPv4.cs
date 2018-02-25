using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questions
{
    public class IPv4
    {
        public bool isIPv4Address(string inputString)
        {
            const int maxIPv4Decimal = 255;
            const int minIPv4Decimal = 0;
            const int numDots = 3;
            const int nums = 4;
            try
            {
                var decimals = inputString.Split('.').Select(int.Parse);
                var dots = inputString.Count(c => c == '.');

                return decimals.All(i => i <= maxIPv4Decimal)
                       && decimals.All(i => i >= minIPv4Decimal)
                       && dots == numDots
                       && decimals.Count() == nums;
            }
            catch (Exception e)
            {
                // ".254.255.0" will throw an exception
                // not a valid address so return false
                return false;
            }
        }
    }
}
