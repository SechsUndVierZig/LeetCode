﻿using System;

public class Assignment10
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            bool[][] dp = new bool[s.Length + 1][];
            for (int i = 0; i < s.Length + 1; i++)
                dp[i] = new bool[p.Length + 1];
            dp[0][0] = true;

            for (int j = 1; j < p.Length + 1; j++)
                dp[0][j] = p[j - 1] == '*' && dp[0][j - 2];

            for (int i = 1; i < s.Length + 1; i++)
            {
                for (int j = 1; j < p.Length + 1; j++)
                {
                    if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                        dp[i][j] = dp[i - 1][j - 1];
                    else if (p[j - 1] == '*')
                        dp[i][j] = dp[i][j - 2] || (s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1][j];
                }
            }
            return dp[s.Length][p.Length];
        }
    }
}
