using System;

public class FirstAssigment
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int arrayLength = nums.Length;

            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }
            return Array.Empty<int>();
        }
    }
}
