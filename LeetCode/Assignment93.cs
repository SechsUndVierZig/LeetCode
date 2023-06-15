using System;
using System.Collections.Generic;

public class Assignment93
{
    public class Solution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            List<string> r = new List<string>();
            if (s.Length > 12 || s.Length < 4) return r;


            void solve(int i, int dots, string cur)
            {
                if (dots == 4 && i == s.Length)
                {
                    r.Add(cur.Remove(cur.Length - 1, 1));
                    return;
                }

                for (int j = i; j < Math.Min(i + 3, s.Length); j++)
                {
                    string part = s.Substring(i, j - i + 1);
                    if (part[0] == '0' && part.Length > 1) continue;
                    if (Int32.Parse(part) < 256)
                    {
                        solve(j + 1, dots + 1, cur + part + ".");
                    }

                }
            }


            solve(0, 0, "");
            return r;

        }
    }
}
