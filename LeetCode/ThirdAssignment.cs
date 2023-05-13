using System;
using System.Collections.Generic;

public class ThirdAssignment
{
    public class Solution4
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            var map_str = new Dictionary<char, int>();
            var max_len = 0;
            var last_repeat_pos = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (map_str.ContainsKey(s[i]) && last_repeat_pos < map_str[s[i]])
                    last_repeat_pos = map_str[s[i]];
                if (max_len < i - last_repeat_pos)
                    max_len = i - last_repeat_pos;
                map_str[s[i]] = i;
            }
            return max_len;
        }
    }
}
