using System;

public class Assignment76
{
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            var map = new int[128, 2];
            foreach (var t1 in t)
                map[t1, 0]++;
            var left = 0;
            var matches = 0;
            var result = string.Empty;
            for (int right = 0; right < s.Length; right++)
            {
                map[s[right], 1]++;

                if (map[s[right], 0] >= map[s[right], 1])
                    matches++;

                while (matches == t.Length)
                {
                    if (right - left + 1 < result.Length || result.Length == 0)
                        result = s.Substring(left, right - left + 1);

                    map[s[left], 1]--;
                    if (map[s[left], 0] > map[s[left], 1])
                        matches--;

                    left++;
                }
            }

            return result;
        }
    }
}
