using System;

public class Assignment198
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int max = nums[0];
            int s = 0;

            foreach (int n in nums[1..])
                (max, s) = (Math.Max(n + s, max), max);

            return max;
        }
    }
}
