using System;

public class Assignment233
{
    public class Solution
    {
        public int CountDigitOne(int n)
        {
            int ones = 0, m = 1;
            while (m <= n)
            {
                int a = n / m, b = n % m;
                ones += (a + 8) / 10 * m;
                if (a % 10 == 1) ones += b + 1;
                m *= 10;
            }
            return ones;
        }

    }
}
