using System;

public class Assignment204
{
    public class Solution
    {
        public int CountPrimes(int n)
        {
            if (n <= 2) return 0;
            int result = 0;
            bool[] sieve = new bool[n];
            for (int i = 2; i < n; i++)
            {
                if (sieve[i]) continue;
                result++;

                int count = 2;
                while (i * count < n)
                {
                    sieve[i * count] = true;
                    count++;
                }
            }
            return result;
        }
    }
}
