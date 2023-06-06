using System;
using System.Linq;

public class Assignment72
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            var m = word1.Length;
            var n = word2.Length;
            var prevRow = new int[n + 1];

            for (var j = 0; j <= n; j++)
                prevRow[j] = j;

            for (var i = 0; i < m; i++)
            {
                var curRow = new int[n + 1];
                curRow[0] = i + 1;

                for (var j = 0; j < n; j++)
                {
                    if (word1[i] == word2[j])
                        curRow[j + 1] = Min(prevRow[j], prevRow[j + 1] + 1, curRow[j] + 1);
                    else
                        curRow[j + 1] = Min(prevRow[j], prevRow[j + 1], curRow[j]) + 1;
                }
                prevRow = curRow;
            }

            return prevRow[n];

            int Min(params int[] arr)
            {
                return arr.Min();
            }
        }
    }
}
