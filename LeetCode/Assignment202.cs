using System;
using System.Collections.Generic;

public class Assignment202
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();

            while (n != 1)
            {
                string str = n.ToString();
                int sum = 0;

                foreach (char c in str)
                {
                    int digit = c - '0';
                    sum += digit * digit;
                }

                if (set.Contains(sum))
                    return false;

                set.Add(sum);
                n = sum;
            }

            return true;
        }
    }
}
