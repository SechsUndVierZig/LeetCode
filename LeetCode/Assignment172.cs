using System;

public class Assignment172
{
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            var count = 0;
            for (var i = 5; i <= n; i *= 5) count += n / i;

            return count;
        }
    }
}
