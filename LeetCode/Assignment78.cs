using System;
using System.Collections.Generic;

public class Assignment78
{
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();
            subsets.Add(new List<int>());
            for (int i = 0; i < nums.Length; i++)
            {
                int count = subsets.Count;
                for (int j = 0; j < count; j++)
                {
                    var temp = subsets[j].ToList();
                    temp.Add(nums[i]);
                    subsets.Add(temp);
                }
            }
            return subsets;
        }
    }
}
