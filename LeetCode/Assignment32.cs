using System;

public class Assignment32
{
    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            var dp = new int[s.Length + 1];

            for (int i = 1; i < s.Length; i++)
            {
                var continueValidParentheses = GetContinueValidParenthese(s, i);
                dp[i + 1] = Math.Max(dp[i], continueValidParentheses);
            }
            return dp[s.Length];
        }
        private int GetContinueValidParenthese(string str, int end)
        {
            var res = 0;
            var temp = 0;
            var rightParenthese = 0;
            for (int i = end; i >= 0; i--)
            {
                if (str[i] == '(')
                {
                    if (rightParenthese == 0) return res;

                    temp += 2;
                    rightParenthese--;
                    if (rightParenthese == 0) res = temp;
                }
                else rightParenthese++;
            }

            return res;
        }
    }
}
