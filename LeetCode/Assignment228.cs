using System;

public class Assignment228
{
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();

            if (nums == null || nums.Length == 0)
                return result;

            int n = nums.Length;
            int start = nums[0];

            for (int i = 0; i < n; i++)
            {
                if (i < n - 1 && nums[i + 1] == nums[i] + 1)
                    continue;

                if (start == nums[i])
                    result.Add(start.ToString());
                else
                    result.Add(start + "->" + nums[i]);

                if (i < n - 1)
                    start = nums[i + 1];
            }
            return result;

        }
    }
}
