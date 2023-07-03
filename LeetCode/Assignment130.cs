using System;
using System.Collections.Generic;

public class Assignment130
{
    public class Solution
    {
        private const char X = 'X';
        private const char O = 'O';
        private const char Temp = 'T';

        public void Solve(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            if (m == 1 || n == 1) return;

            for (int cidx = 0; cidx < n; cidx++)
            {
                Visit(0, cidx, grid);
                Visit(m - 1, cidx, grid);
            }

            for (int ridx = 1; ridx < m - 1; ridx++)
            {
                Visit(ridx, 0, grid);
                Visit(ridx, n - 1, grid);
            }

            for (int ridx = 0; ridx < m; ridx++)
            {
                for (int cidx = 0; cidx < n; cidx++)
                {
                    grid[ridx][cidx] = grid[ridx][cidx] switch
                    {
                        O => X,
                        Temp => O,
                        _ => grid[ridx][cidx]
                    };
                }
            }
        }

        private void Visit(int r, int c, char[][] grid)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return;
            }
            else if (grid[r][c] == X || grid[r][c] == Temp)
            {
                return;
            }

            grid[r][c] = Temp;

            foreach (var (x, y) in GetNeighbours(r, c))
            {
                Visit(x, y, grid);
            }
        }

        private IEnumerable<(int, int c)> GetNeighbours(int r, int c)
        {
            yield return (r + 1, c);
            yield return (r - 1, c);
            yield return (r, c + 1);
            yield return (r, c - 1);
        }
    }
}
