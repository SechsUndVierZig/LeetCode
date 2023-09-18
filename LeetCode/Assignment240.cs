﻿using System;

public class Assignment240
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int column = matrix[0].Length - 1;
            int row = 0;
            while (column >= 0 && row < matrix.Length)
            {
                if (matrix[row][column] == target)
                    return true;
                else if (matrix[row][column] > target)
                    column--;
                else if (matrix[row][column] < target)
                    row++;
            }
            return false;
        }
    }
}
