using System;
using System.Collections.Generic;

public class Assignment119
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            int[] v = new int[rowIndex + 1];
            v[0] = 1;
            for (int i = 0; i <= rowIndex; ++i)
            {
                for (int j = i; j > 0; --j)
                    v[j] = v[j] + v[j - 1];
            }
            return v;
        }
    }
}
