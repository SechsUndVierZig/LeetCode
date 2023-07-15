using System;
using System.Collections.Generic;

public class Assignment149
{
    public class Solution
    {
        public int MaxPoints(int[][] points)
        {
            int n = points.Length;
            if (n == 1) return 1;
            int result = 2;
            for (int i = 0; i < n; ++i)
            {
                var cnt = new Dictionary<double, int>();
                for (int j = 0; j < n; ++j)
                {
                    if (j != i)
                    {
                        var angle = Math.Atan2(points[j][1] - points[i][1], points[j][0] - points[i][0]);
                        cnt[angle] = cnt.GetValueOrDefault(angle, 0) + 1;
                    }
                }
                result = Math.Max(result, cnt.Values.Max() + 1);
            }
            return result;
        }
    }
}
}
