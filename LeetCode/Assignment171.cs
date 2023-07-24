using System;

public class Assignment171
{
    public class Solution
    {
        public int TitleToNumber(string columnTitle)
        {
            int output = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                int curr = columnTitle[i] - 'A' + 1;
                output = output * 26 + curr;
            }
            return output;
        }
    }
}
