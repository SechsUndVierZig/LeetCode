using System;

public class Assignment52
{
    public class Solution
    {
        public int TotalNQueens(int n)
        {
            return this.TotalNQueens(n, 0, new int[n], new bool[n]);
        }
        public int TotalNQueens(int n, int y, int[] prevX, bool[] usedX)
        {
            // when we run into y, [0, y) row queens are already in place
            if (n == y) return 1;
            int retval = 0;

            // Go through all valid X
            for (int x = 0; x < n; x++)
            {
                bool valid = !usedX[x];
                for (int prevY = 0; prevY < y && valid; prevY++)
                {
                    if (Math.Abs(prevY - y) == Math.Abs(prevX[prevY] - x)) valid = false; // if cross happens, it's invalid
                }

                if (valid)
                {
                    prevX[y] = x;
                    usedX[x] = true;
                    retval += this.TotalNQueens(n, y + 1, prevX, usedX);
                    usedX[x] = false;
                }
            }

            return retval;
        }
    }
}
