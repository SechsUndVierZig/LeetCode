using System;
using System.Collections.Generic;

public class Assignment140
{
    public class Solution
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            IList<string> result = new List<string>();

            DFSWordBreak(0, s, "", wordDict, "", result);

            return result;
        }

        public void DFSWordBreak(int index, string s, string word, IList<string> wordDict, string current, IList<string> result)
        {
            if (index == s.Length)
            {
                result.Add(current.Substring(1));
                return;
            }

            for (int i = index; i < s.Length; i++)
            {
                var currentW = s.Substring(index, i - index + 1);
                if (wordDict.Contains(currentW))
                {
                    current += " " + currentW;
                    DFSWordBreak(i + 1, s, "", wordDict, current, result);
                    current = current.Substring(0, current.Length - (currentW.Length + 1));
                }
            }
        }
    }
}
