﻿using System;

public class Assignment132
{
    public class Solution
    {
        public int MinCut(string s)
        {
            var n = s.Length;

            var dp = new int[n];
            var isPalindromes = new bool[n, n];

            for (int i = 0; i < n; i++)
            {
                isPalindromes[i, i] = true;
            }

            for (int right = 1; right < n; right++)
            {
                for (int left = 0; left < right; left++)
                {
                    if (s[left] == s[right] && (left + 1 == right || isPalindromes[left + 1, right - 1]))
                        isPalindromes[left, right] = true;
                }
            }

            for (int right = 1; right < n; right++)
            {
                dp[right] = dp[right - 1] + 1;
                for (int left = 0; left < right; left++)
                {
                    if (isPalindromes[left, right])
                    {
                        if (left == 0)
                            dp[right] = Math.Min(dp[right], 0);
                        else
                            dp[right] = Math.Min(dp[right], dp[left - 1] + 1);

                    }
                }
            }

            return dp[n - 1];
        }
    }
}
