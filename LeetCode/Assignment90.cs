using System;

public class Assignment90
{
    public class Solution
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            Backtrack(result, new List<int>(), 0, nums);
            return result;
        }
        private void Backtrack(IList<IList<int>> sets, List<int> curr, int index, int[] nums)
        {
            sets.Add(new List<int>(curr));
            for (int i = index; i < nums.Length; i++)
            {
                if (i > index && nums[i] == nums[i - 1]) continue;
                curr.Add(nums[i]);
                Backtrack(sets, curr, i + 1, nums);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}
