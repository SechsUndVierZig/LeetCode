using System;

public class Assignment189
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if (nums.Length <= 1 || k == 0) return;
            reverse(nums, 0, nums.Length - 1 - k);
            reverse(nums, nums.Length - k, nums.Length - 1);
            reverse(nums, 0, nums.Length - 1);
        }
        public void reverse(int[] nums, int start, int end)
        {
            for (int i = 0; i <= (end - start) / 2; i++)
            {
                int tmp = nums[i + start];
                nums[i + start] = nums[end - i];
                nums[end - i] = tmp;
            }
        }
    }
}
