using System;
using System.Collections.Generic;
using System.Linq;

public class Class1
{
    public class Solution
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var degree = new int[numCourses];

            var parentToChildren = prerequisites.ToLookup(
                    p => p[1],
                    c => { degree[c[0]]++; return c[0]; });

            var bfs = new List<int>(numCourses);

            for (int i = 0; i < numCourses; ++i)
                if (degree[i] == 0) bfs.Add(i);

            for (int i = 0; i < bfs.Count; ++i)
            {
                foreach (var j in parentToChildren[bfs[i]])
                {
                    if (--degree[j] == 0)
                        bfs.Add(j);
                }
            }

            return bfs.Count == numCourses ? bfs.ToArray() : new int[0];
        }
    }
}
