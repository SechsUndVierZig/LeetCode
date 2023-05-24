using System;

public class Assignment37
{
    public class Solution
    {
        public void SolveSudoku(char[][] board)
        {
            if (board == null) return;
            backtrack(board, 0, 0);
        }
        private bool backtrack(char[][] board, int row, int col)
        {
            if (col == 9)
            {
                col = 0; ++row;
                if (row == 9) return true;
            }
            if (board[row][col] != '.')
                return backtrack(board, row, col + 1);

            for (char v = '1'; v <= '9'; v++)
            {
                if (isValid(board, row, col, v))
                {
                    board[row][col] = v;
                    if (backtrack(board, row, col + 1)) return true;
                    else board[row][col] = '.';
                }
            }
            return false;
        }
        private bool isValid(char[][] board, int row, int col, char val)
        {
            for (int r = 0; r < 9; r++)
                if (board[r][col] == val) return false;
            for (int c = 0; c < 9; c++)
                if (board[row][c] == val) return false;
            int I = row / 3; int J = col / 3;
            for (int a = 0; a < 3; a++)
                for (int b = 0; b < 3; b++)
                    if (val == board[3 * I + a][3 * J + b]) return false;
            return true;

        }
    }
}
