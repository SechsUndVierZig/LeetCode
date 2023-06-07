using System;

public class Assignment74
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var (rows, cols) = (matrix.Length, matrix[0].Length);
            var (l, r) = (0, rows * cols - 1);
            while (l < r)
            {
                var m = l + (r - l) / 2;

                (l, r) = matrix[m / cols][m % cols] >= target ? (l, m) : (m + 1, r);
            }
            return matrix[l / cols][l % cols] == target;
        }
    }
}
