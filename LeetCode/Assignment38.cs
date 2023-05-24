using System;
using System.Text;

public class Assignment38
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            var start = "1";
            while (--n > 0)
                start = SayNext(start);

            return start;
        }
        private static string SayNext(string start)
        {
            var res = new StringBuilder();
            var pre = 0;
            for (int i = 0; i < start.Length; i++)
            {
                if (start[i] != start[pre])
                {
                    res.Append(i - pre).Append(start[pre]);
                    pre = i;
                }
            }
            res.Append(start.Length - pre).Append(start[pre]);
            return res.ToString();
        }
    }
}
