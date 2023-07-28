using System;

public class Assignment191
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            uint res = 0;
            while (n > 0)
            {
                res += n & 1;
                n = n >> 1;
            }
            return (int)res;
        }
    }
}
