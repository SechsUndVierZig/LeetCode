using System;
using System.Collections.Generic;

public class Assignment46
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<int> tempLst = new List<int>();
            IList<IList<int>> result = new List<IList<int>>();

            PerformPermutations(nums, result, tempLst);
            return result;
        }

        private void PerformPermutations(int[] nums, IList<IList<int>> result, IList<int> tempLst)
        {
            if (tempLst.Count == nums.Length)
            {
                result.Add(new List<int>(tempLst));
                return;
            }
            else
                for (int i = 0; i < nums.Length; i++)
                {
                    if (tempLst.Contains(nums[i]))
                        continue;
                    tempLst.Add(nums[i]);
                    PerformPermutations(nums, result, tempLst);
                    tempLst.RemoveAt(tempLst.Count - 1);
                }
        }
    }
}
