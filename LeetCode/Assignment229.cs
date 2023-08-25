using System;
using System.Collections.Generic;

public class Assignment229
{
    public class Solution
    {
        public IList<int> MajorityElement(int[] nums)
        {
            Dictionary<int, int> arr = new Dictionary<int, int>();
            List<int> ans = new List<int>();
            int x = 0;
            foreach (int a in nums)
            {
                if (arr.TryAdd(a, 1) == false)
                    arr[a]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                arr.TryGetValue(nums[i], out x);
                if (x > nums.Length / 3)
                    ans.Add(nums[i]);
            }
            return (ans.Distinct().ToArray());
        }
    }
}
