using System;
using System.Collections.Generic;

public class Assignment36
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!isParticallyValid(board, i, 0, i, 8))
                    return false;
                if (!isParticallyValid(board, 0, i, 8, i))
                    return false;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (!isParticallyValid(board, i * 3, j * 3, i * 3 + 2, j * 3 + 2))
                        return false;
            return true;
        }

        bool isParticallyValid(char[][] board, int x1, int y1, int x2, int y2)
        {
            var set = new HashSet<char>();
            for (int row = x1; row <= x2; row++)
                for (int col = y1; col <= y2; col++)
                    if (board[row][col] != '.')
                        if (!set.Add(board[row][col]))
                            return false;
            return true;
        }

    }
}
