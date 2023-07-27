using System;

public class Assignment188
{
    public class Solution
    {
        private int[,] dp;
        public int MaxProfit(int k, int[] prices)
        {

            dp = new int[prices.Length + 1, 2 * k + 1];

            System.Threading.Tasks.Parallel.For(0, prices.Length + 1, x => {
                for (int y = 0; y < 2 * k + 1; ++y)
                    dp[x, y] = -1;
            });

            return solve(0, 2 * k, prices);
        }

        private int solve(int i, int tno, int[] p)
        {
            if (i == p.Length || tno == 0) return 0;
            if (dp[i, tno] != -1) return dp[i, tno];

            if (tno % 2 == 0)
                return dp[i, tno] = Math.Max(-p[i] + solve(i + 1, tno - 1, p), solve(i + 1, tno, p));


            return dp[i, tno] = Math.Max(p[i] + solve(i + 1, tno - 1, p), solve(i + 1, tno, p));
        }
    }
}
