using System;

public class Assignment213
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            return Math.Max(RobRange(nums, 0, nums.Length - 2), RobRange(nums, 1, nums.Length - 1));

            int RobRange(int[] nums, int start, int end)
            {
                var rob1 = 0;
                var rob2 = 0;
                for (int i = start; i <= end; i++)
                {
                    var temp = Math.Max(rob1 + nums[i], rob2);
                    rob1 = rob2;
                    rob2 = temp;
                }
                return rob2;
            }
        }
    }
}
