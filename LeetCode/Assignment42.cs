﻿using System;

public class Assignment42
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            var res = 0;
            var max = 0;
            var left = 0;
            var right = height.Length - 1;

            while (left <= right)
            {
                if (height[left] < height[right])
                {
                    max = Math.Max(max, height[left]);
                    res += max - height[left];
                    left++;
                }
                else
                {
                    max = Math.Max(max, height[right]);
                    res += max - height[right];
                    right--;
                }
            }

            return res;
        }
    }
}
