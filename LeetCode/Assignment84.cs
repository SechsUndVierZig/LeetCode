using System;
using System.Collections.Generic;

public class Assignment84
{
    public class Solution
    {
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (s.Count > 0 && heights[s.Peek()] >= heights[i])
                    s.Pop();
                left[i] = s.Count == 0 ? 0 : s.Peek() + 1;
                s.Push(i);
            }

            s.Clear();

            for (int i = n - 1; i >= 0; i--)
            {
                while (s.Count > 0 && heights[s.Peek()] >= heights[i])
                    s.Pop();
                right[i] = s.Count == 0 ? n - 1 : s.Peek() - 1;
                s.Push(i);
            }
            int maxArea = 0;
            for (int i = 0; i < n; i++)
                maxArea = Math.Max(maxArea, heights[i] * (right[i] - left[i] + 1));
            return maxArea;
        }
    }
}
