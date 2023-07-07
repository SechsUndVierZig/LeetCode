using System;
using System.Collections.Generic;
using System.Linq;

public class Assignment136
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (lst.Contains(nums[i]))
                    lst.Remove(nums[i]);
                else
                    lst.Add(nums[i]);
            }
            return lst[0];
        }
    }
}
