using System;
using System.Collections.Generic;
using System.Linq;

public class Assignment30
{
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {

            int size_word = words[0].Length;
            int word_count = words.Count();

            int size_L = size_word * word_count;

            List<int> res = new List<int>();
            if (size_L > s.Length)
                return res;
            Dictionary<string, int> hash_map = new Dictionary<string, int>();
            foreach (string word in words)
                hash_map[word] = hash_map.GetValueOrDefault(word, 0) + 1;
            for (int i = 0; i <= s.Length - size_L; i++)
            {
                Dictionary<string, int> temp_hash_map = new Dictionary<string, int>(hash_map);
                int j = i, count = word_count;
                while (j < i + size_L)
                {
                    string word = s.Substring(j, size_word);

                    if (!hash_map.ContainsKey(word) || temp_hash_map[word] == 0)
                        break;
                    else
                    {
                        temp_hash_map[word]--;
                        count--;
                    }
                    j += size_word;
                }
                if (count == 0)
                    res.Add(i);
            }
            return res;
        }
    }
}
