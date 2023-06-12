using System;
using System.Collections.Generic;

public class Assignment85
{
    public class Solution
    {
        public int MaximalRectangle(char[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[] mat = new int[n];
            int mx = Int32.MinValue;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((matrix[i][j] == '0'))
                        mat[j] = 0;
                    else
                        mat[j] += matrix[i][j] - '0';
                }
                mx = Math.Max(mx, Histogram(mat));
            }
            return mx;
        }
        int Histogram(int[] array)
        {
            int n = array.Length;
            int[] left = NSL(array, n);
            int[] right = NSR(array, n);
            int[] width = new int[n];
            int max = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                width[i] = right[i] - left[i] - 1;
                max = Math.Max(max, array[i] * width[i]);
            }
            return max;
        }
        int[] NSL(int[] arr, int n)
        {
            int[] left = new int[n];
            Stack<int> s = new();
            for (int i = 0; i < n; i++)
            {
                while (s.Count > 0 && arr[s.Peek()] >= arr[i])
                    s.Pop();
                if (s.Count == 0)
                    left[i] = -1;
                else
                    left[i] = s.Peek();
                s.Push(i);
            }
            return left;
        }
        int[] NSR(int[] arr, int n)
        {
            int[] right = new int[n];
            Stack<int> s = new();
            for (int i = n - 1; i >= 0; i--)
            {
                while (s.Count > 0 && arr[s.Peek()] >= arr[i])
                    s.Pop();
                if (s.Count == 0)
                    right[i] = n;
                else
                    right[i] = s.Peek();
                s.Push(i);
            }
            return right;
        }
    }
}
