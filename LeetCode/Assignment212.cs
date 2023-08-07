using System;
using System.Collections.Generic;
using System.Linq;

public class Assignment212
{
    public class Solution
    {
        int Y;
        int X;
        char[][] c;
        HashSet<int> reversed;

        bool isChar(int x, int y, char ch)
        {
            return x >= 0 && x < X && y >= 0 && y < Y && c[y][x] == ch;
        }

        bool Find(int x, int y, string s, int i)
        {
            if (i >= s.Length)
                return true;

            if (!isChar(x, y, s[i]))
                return false;

            c[y][x] = '.';
            bool res = Find(x - 1, y, s, i + 1) ||
                       Find(x + 1, y, s, i + 1) ||
                       Find(x, y + 1, s, i + 1) ||
                       Find(x, y - 1, s, i + 1);
            c[y][x] = s[i];
            return res;
        }

        string Reverse(string s)
        {
            var cs = s.ToCharArray();
            Array.Reverse(cs);
            return new String(cs);
        }

        bool ShouldReverse(string s)
        {
            return (s.Length > 5) && (s[0] == s[1] && s[1] == s[2] && s[2] == s[3] && s[3] == s[4]);
        }

        public IList<string> FindWords(char[][] board, string[] words)
        {
            c = board;
            Y = c.Length;
            X = c[0].Length;
            Dictionary<char, List<(int, int)>> p = new Dictionary<char, List<(int, int)>>();
            HashSet<char> chars = new HashSet<char>();
            for (int y = 0; y < Y; y++)
                for (int x = 0; x < X; x++)
                {
                    if (!p.ContainsKey(c[y][x]))
                        p[c[y][x]] = new List<(int, int)>();
                    p[c[y][x]].Add((x, y));
                    chars.Add(c[y][x]);
                }

            HashSet<int> reversed = new HashSet<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (ShouldReverse(words[i]))
                {
                    words[i] = Reverse(words[i]);
                    reversed.Add(i);
                }
            }

            for (int i = 0; i < words.Length; i++)
                if (words[i].Count(x => !chars.Contains(x)) > 0)
                    words[i] = "";

            List<string> res = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                    continue;

                for (int k = 0; k < p[words[i][0]].Count; k++)
                {
                    if (Find(p[words[i][0]][k].Item1, p[words[i][0]][k].Item2, words[i], 0))
                    {
                        if (reversed.Contains(i))
                            words[i] = Reverse(words[i]);

                        res.Add(words[i]);
                        break;
                    }
                }
            }
            return res;
        }
    }
}
