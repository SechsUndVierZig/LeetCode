﻿using System;

public class Assignment201
{
    public class Solution
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            var count = 0;
            while (left != right)
            {
                count++;
                left = left >> 1;
                right = right >> 1;
            }
            return left << count;
        }
    }
}
