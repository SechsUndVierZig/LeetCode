using System;
using System.Collections.Generic;

public class Assignment128
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int maxLength = 0;

            foreach (int num in nums)
            {
                if (set.Contains(num - 1)) continue;

                int length = 0;
                while (set.Contains(num + length)) length++;

                maxLength = Math.Max(maxLength, length);
            }

            return maxLength;
        }
    }
}
