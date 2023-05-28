using System;

public class Assignment48
{
    public class Solution
    {
        public int[][] Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    int offset = i - first;

                    //top
                    int top = matrix[first][i];

                    //top replaced by left
                    matrix[first][i] = matrix[last - offset][first];

                    //left replaced by bottom
                    matrix[last - offset][first] = matrix[last][last - offset];

                    //bottom replaced by right
                    matrix[last][last - offset] = matrix[i][last];

                    //right replaced by top
                    matrix[i][last] = top;
                }
            }

            return matrix;
        }
    }
}
