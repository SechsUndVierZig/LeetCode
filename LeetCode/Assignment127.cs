using System;
using System.Collections.Generic;

public class Assignment127
{
    public class Solution
    {
        Dictionary<string, int> map;
        IList<string> wordlist;
        public int LadderLength(string beginWord, string endWord, IList<string> wordList1)
        {
            map = new Dictionary<string, int>();
            wordlist = wordList1;
            for (int i = 0; i < wordlist.Count; i++)
            {
                map[wordlist[i]] = i;
            }

            if (!map.ContainsKey(endWord)) return 0;

            int target = map[endWord];
            int n = wordlist.Count;

            wordlist.Add(beginWord);

            Queue<int> q = new Queue<int>();
            HashSet<int> uplayerset = new HashSet<int>();
            q.Enqueue(n);

            uplayerset.Add(n);
            int depth = 0;
            bool reached = false;

            while (q.Count > 0 && !reached)
            {
                var nextlayerset = new HashSet<int>();
                depth++;

                var qsize = q.Count;
                for (int i = 0; i < qsize; i++)
                {
                    // termination

                    var cur = q.Dequeue();

                    if (cur == target) { reached = true; break; }

                    var nexts = findNeighbors(cur);

                    foreach (var next in nexts)
                    {
                        if (!uplayerset.Contains(next))
                        {
                            // add it into adj list

                            if (!nextlayerset.Contains(next))
                            {
                                nextlayerset.Add(next);
                                q.Enqueue(next);
                            }
                        }
                    }
                }

                foreach (var nl in nextlayerset)
                {
                    uplayerset.Add(nl);
                }
            }

            return reached ? depth : 0;
        }

        private List<int> findNeighbors(int iword)
        {
            var res = new List<int>();
            var word = wordlist[iword].ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                var oldchar = word[i];

                for (char j = 'a'; j <= 'z'; j++)
                {
                    word[i] = j;
                    if (j != oldchar && map.TryGetValue(new string(word), out int index) && index != iword)
                    {
                        res.Add(index);
                    }
                }

                word[i] = oldchar;
            }

            return res;
        }
    }
}
