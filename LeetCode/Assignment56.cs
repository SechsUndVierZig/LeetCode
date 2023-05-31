using System;
using System.Collections.Generic;
using System.Linq;

public class Assignment56
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> results = intervals.ToList();

            if (intervals.Length <= 1) return intervals;

            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];

            for (int k = 0; k < intervals.Length; k++)
            {
                start[k] = results[k][0];
                end[k] = results[k][1];
            }

            Array.Sort(start);
            Array.Sort(end);

            results.Clear();

            int[] current = new int[] { start[0], end[0] };
            int i = 0;
            while (i < intervals.Length)
            {
                if (current[1] >= start[i])
                    current[1] = end[i];

                else
                {
                    results.Add(current);
                    current = new int[] { start[i], end[i] };
                }
                i++;
            }
            results.Add(current);

            return results.ToArray();
        }
    }
}
