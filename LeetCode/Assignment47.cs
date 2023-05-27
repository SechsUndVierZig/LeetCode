using System;
using System.Collections.Generic;

public class Assignment47
{
    public class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            bool[] used = new bool[nums.Length];
            Backtracking(nums, new List<int>(), res, used);
            return res;
        }

        private void Backtracking(int[] nums, List<int> list, List<IList<int>> res, bool[] used)
        {
            if (list.Count == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i > 0 && nums[i] == nums[i - 1] && used[i - 1] || used[i]) continue;

                    list.Add(nums[i]);
                    used[i] = true;
                    Backtracking(nums, list, res, used);
                    list.RemoveAt(list.Count - 1);
                    used[i] = false;
                }
            }
        }
    }
}
