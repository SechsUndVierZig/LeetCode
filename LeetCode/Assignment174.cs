using System;

public class Assignment174
{
    public class Solution
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int r = dungeon.Length;
            int c = dungeon[0].Length;
            int[,] dp = InitializeDPArray(r, c);

            dp[r - 1, c - 1] = Math.Max(1, 1 - dungeon[r - 1][c - 1]);

            for (int i = c - 2; i >= 0; i--)
                dp[r - 1, i] = Math.Max(1, dp[r - 1, i + 1] - dungeon[r - 1][i]);
            for (int i = r - 2; i >= 0; i--)
                dp[i, c - 1] = Math.Max(1, dp[i + 1, c - 1] - dungeon[i][c - 1]);
            for (int i = r - 2; i >= 0; i--)
            {
                for (int j = c - 2; j >= 0; j--)
                {
                    int min = Math.Min(dp[i + 1, j], dp[i, j + 1]);
                    dp[i, j] = Math.Max(1, min - dungeon[i][j]);
                }
            }

            return dp[0, 0];
        }

        private int[,] InitializeDPArray(int r, int c)
        {
            int[,] dp = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    dp[i, j] = int.MaxValue;
            }

            return dp;
        }
    }
}
