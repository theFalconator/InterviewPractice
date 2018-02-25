using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Questions
{
    public class MaximalAdjacentDifference
    {
        public int arrayMaximalAdjacentDifferrence(int[] inputArray)
        {
            // offset input array by 1
            var offsetInputArray = inputArray.Skip(1);
            
            // first - second
            var diffs = inputArray.Zip(offsetInputArray, (x, y) => x - y);

            // second - first
            var diffs2 = inputArray.Zip(offsetInputArray, (x, y) => y - x);

            // maximum from both cases
            var result = new[] {diffs.Max(), diffs2.Max()};

            // return largest
            return result.Max();
        }
    }
}
