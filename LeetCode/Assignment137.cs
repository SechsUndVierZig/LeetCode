﻿using System;

public class Assignment137
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int ones = 0;
            int twos = 0;

            foreach (int num in nums)
            {
                ones = (ones ^ num) & ~twos;
                twos = (twos ^ num) & ~ones;
            }

            return ones;
        }
    }

}
