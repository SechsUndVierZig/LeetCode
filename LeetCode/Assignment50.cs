using System;

public class Assignment50
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            long N = n;
            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }
            double ans = 1;
            double curr = x;
            for (long i = N; i > 0; i = i / 2)
            {
                if (i % 2 == 1) ans = ans * curr;
                curr = curr * curr;
            }

            return ans;
        }
    }
}
