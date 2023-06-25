using System;

public class Assignment115
{
    public class Solution
    {
        public int NumDistinct(string s, string t)
        {
            int?[,] dp = new int?[s.Length, t.Length];
            return Backtracking(0, 0);

            int Backtracking(int indexOfInput, int indexOfTarget)
            {
                if (indexOfTarget == t.Length) return 1;
                if (indexOfInput == s.Length) return 0;

                if (dp[indexOfInput, indexOfTarget] is { } result) return result;

                if (s[indexOfInput] != t[indexOfTarget]) return dp[indexOfInput, indexOfTarget] ??= Backtracking(indexOfInput + 1, indexOfTarget);

                return dp[indexOfInput, indexOfTarget] ??= Backtracking(indexOfInput + 1, indexOfTarget)
                                                           + Backtracking(indexOfInput + 1, indexOfTarget + 1);
            }
        }
    }
}
