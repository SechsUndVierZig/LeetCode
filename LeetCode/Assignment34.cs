﻿using System;

public class Assignment34
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int start = BinarySearch(nums, target, true);
            int end = BinarySearch(nums, target, false);
            return new int[] { start, end };
        }
        private int BinarySearch(int[] nums, int target, bool leftBais)
        {
            int l = 0, r = nums.Length - 1, mid = 0;
            int index = -1;
            while (l <= r)
            {
                mid = l + (r - l) / 2;
                if (target > nums[mid]) l = mid + 1;
                else if (target < nums[mid]) r = mid - 1;
                else
                {
                    index = mid;
                    if (leftBais) r = mid - 1;
                    else l = mid + 1;
                }
            }
            return index;
        }
    }
}
