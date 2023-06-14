using System;
using System.Collections.Generic;

public class Assignment89
{
    public class Solution
    {
        public IList<int> GrayCode(int n)
        {
            if (n == 1)
                return new List<int> { 0, 1 };

            IList<int> list = GrayCode(n - 1);
            IList<int> ans = new List<int>();

            for (int i = 0; i < list.Count; i++)
                ans.Add(0 << n - 1 | list[i]);

            for (int i = list.Count() - 1; i >= 0; i--)
                ans.Add(1 << n - 1 | list[i]);

            return ans;
        }
    }
}
