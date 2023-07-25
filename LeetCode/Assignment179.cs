using System;
using System.Linq;

public class Assignment179
{
    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            if (nums.All(_ => _ == 0)) return "0";

            var s = nums.Select(_ => _.ToString()).ToList();

            s.Sort((a, b) => (b + a).CompareTo(a + b));

            return string.Concat(s);
        }
    }
}
