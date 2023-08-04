using System;

public class Assignment209
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue;
            int sum = 0;
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }

            return minLength != int.MaxValue ? minLength : 0;
        }
    }
}
