using System;

public class Assignment63
{
    public class Solution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            for (int i = 0; i < obstacleGrid.Length; i++)
            {
                for (int j = 0; j < obstacleGrid[0].Length; j++)
                {
                    obstacleGrid[i][j] = (obstacleGrid[i][j], i, j) switch
                    {
                        (1, _, _) => 0,
                        (_, 0, 0) => 1,
                        (_, 0, _) => obstacleGrid[i][j - 1] * 1,
                        (_, _, 0) => obstacleGrid[i - 1][j] * 1,
                        _ => obstacleGrid[i - 1][j] + obstacleGrid[i][j - 1]
                    };
                }
            }
            return obstacleGrid[^1][^1];
        }
    }
}
