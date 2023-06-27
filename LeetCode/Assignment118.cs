using System;

public class Assignment118
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var rs = new List<IList<int>> { new List<int> { 1 } };
            for (int i = 2; i <= numRows; i++)
            {
                var list = new List<int> { 1 };
                for (int j = 1; j < i - 1; j++)
                    list.Add(rs[rs.Count - 1][j - 1] + rs[rs.Count - 1][j]);

                list.Add(1);
                rs.Add(list);
            }
            return rs;
        }
    }
}
