using System;

public class Assignment217
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
                if (nums[i] == nums[i + 1])
                    return true;

            return false;
        }
    }
}
