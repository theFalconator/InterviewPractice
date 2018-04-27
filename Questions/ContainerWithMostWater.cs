using System;
using System.Collections.Generic;
using System.Text;

namespace Questions
{
    public class ContainerWithMostWater
    {
        /*
         * Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai).
         * n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0).
         * Find two lines, which together with x-axis forms a container, such that the
         * container contains the most water.
         * Note: You may not slant the container and n is at least 2.
         */
        public int MaxArea(int[] height)
        {
            if (height.Length < 2)
                return -1;

            var maxArea = 0;

            var left = 0;
            var right = height.Length-1;


            while (left < right) // indexes not wall height
            {
                // shorter wall will dictate max height
                // width is always (right - left) to stay positive
                maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));

                if (height[left] < height[right])
                {
                    // move left wall in one
                    left++;
                }
                else
                {
                    // otherwise move right wall in one
                    right--;
                }
            }

            return maxArea;
        }
    }
}
