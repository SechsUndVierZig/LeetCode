using System;

public class Assignment80
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            int prev = nums[0];
            int len = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == prev && len < 2)
                {
                    len++;
                    k++;
                }
                else if (nums[i] == prev && len >= 2)
                    nums[i] = int.MaxValue;
                else
                {
                    prev = nums[i];
                    len = 1;
                    k++;
                }
            }
            Array.Sort(nums);
            return k;
        }
    }
}
