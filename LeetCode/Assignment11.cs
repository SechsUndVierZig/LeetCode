using System;

public class Assignment11
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            if (height == null || height.Length == 0) return 0;
            int max = 0, i = 0, j = height.Length - 1;
            while (i < j)
            {
                int h = Math.Min(height[i], height[j]);
                int width = j - i;
                max = Math.Max(max, h * width);
                if (height[i] < height[j]) i++;
                else j--;
            }
            return max;
        }
    }
}
