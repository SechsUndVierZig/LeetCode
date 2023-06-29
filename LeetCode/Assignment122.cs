using System;

public class Assignment122
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) { return 0; }
            int min = prices[0];
            int max = prices[0];
            int sum = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > max)
                {
                    max = prices[i];
                    continue;
                }
                if (prices[i] < max)
                {
                    sum += max - min;
                    min = prices[i];
                    max = prices[i];
                }
            }
            sum += max - min;

            return sum;
        }
    }
}
