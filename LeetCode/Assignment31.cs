using System;

public class Assignment31
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            var startIndex = nums.Length - 2;
            while (startIndex >= 0)
            {
                // Find first decreasing element
                if (nums[startIndex] < nums[startIndex + 1]) break;
                --startIndex;
            }

            if (startIndex >= 0)
            {
                int endIndex = nums.Length - 1;

                while (endIndex > startIndex)
                {
                    if (nums[endIndex] > nums[startIndex]) break;
                    --endIndex;
                }
                Swap(ref nums[startIndex], ref nums[endIndex]);
            }
            Reverse(nums, startIndex + 1);
        }

        private void Reverse(int[] nums, int startIndex)
        {
            for (int start = startIndex, end = nums.Length - 1; start < end; ++start, --end)
            {
                Swap(ref nums[start], ref nums[end]);
            }
        }

        private void Swap(ref int a, ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

    }
}
