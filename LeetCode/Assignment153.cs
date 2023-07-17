using System;

public class Assignment153
{
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            int l = 0, r = nums.Length - 1, mid = 0;

            while (nums[l] > nums[r])
            {
                mid = l + (r - l) / 2;
                if (nums[mid] >= nums[l])
                    l = mid + 1;
                else
                    r = mid;
            }
            return nums[l];
        }
    }
}
