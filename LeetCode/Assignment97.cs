using System;

public class Assignment97
{
    public class Solution
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
                return false;

            var cache = new int[s1.Length + 1][];

            for (var i = 0; i < cache.Length; i++)
                cache[i] = new int[s2.Length + 1];

            return IsInterleave(0, 0);

            bool IsInterleave(int p1, int p2)
            {
                int p3 = p1 + p2;

                if (p3 == s3.Length) return true;

                if (cache[p1][p2] != 0) return cache[p1][p2] == 1;

                var r = p1 < s1.Length && s1[p1] == s3[p3] && IsInterleave(p1 + 1, p2)
                     || p2 < s2.Length && s2[p2] == s3[p3] && IsInterleave(p1, p2 + 1);

                cache[p1][p2] = r ? 1 : -1;

                return r;
            }
        }
    }
}
