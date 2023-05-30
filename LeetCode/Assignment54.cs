using System;
using System.Collections.Generic;

public class Assignment54
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new List<int>();
            if (matrix == null || matrix.Length == 0)
                return res;

            int m = matrix.Length;
            int n = matrix[0].Length;
            int top = 0, bottom = m - 1, left = 0, right = n - 1;

            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right && top <= bottom && left <= right; j++)
                    res.Add(matrix[top][j]);
                top++;

                for (int i = top; i <= bottom && top <= bottom && left <= right; i++)
                    res.Add(matrix[i][right]);
                right--;

                for (int j = right; j >= left && top <= bottom && left <= right; j--)
                    res.Add(matrix[bottom][j]);
                bottom--;

                for (int i = bottom; i >= top && top <= bottom && left <= right; i--)
                    res.Add(matrix[i][left]);
                left++;
            }

            return res;
        }
    }
}
