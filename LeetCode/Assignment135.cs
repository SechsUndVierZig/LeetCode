using System;

public class Assignment135
{
    public class Solution
    {
        public int Candy(int[] ratings)
        {
            int maxVal = 1;
            int val = 1;
            int ans = 1;
            int maxIdx = 0;
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    ++val;
                    ans += val;
                    maxIdx = i;
                    maxVal = val;
                }
                else if (ratings[i] < ratings[i - 1])
                {
                    val = 1;
                    ans += i - maxIdx;
                    if (i - maxIdx == maxVal)
                    {
                        maxVal += 1;
                        ans += 1;
                    }
                }
                else
                {
                    maxVal = 1;
                    val = 1;
                    maxIdx = i;
                    ans += 1;
                }
            }
            return ans;



        }
    }
}
