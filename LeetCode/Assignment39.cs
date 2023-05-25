using System;

public class Assignment39
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            IList<IList<int>> res = new List<IList<int>>();
            Find(res, candidates, target, 0, new List<int>());
            return res;
        }

        public void Find(IList<IList<int>> lists, int[] arr, int target, int start, IList<int> curr)
        {
            if (target == 0)
            {
                if (!lists.Contains(curr))
                    lists.Add(new List<int>(curr));
                return;
            }

            for (int i = start; i < arr.Length && arr[i] <= target; i++)
            {
                curr.Add(arr[i]);
                Find(lists, arr, target - arr[i], i, curr);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}
