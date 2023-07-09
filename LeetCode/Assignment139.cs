using System;

public class Assignment139
{
    public class Solution
    {
        List<string> _wordDict;
        HashSet<string> _failed = new();

        public bool WordBreak(string s, IList<string> wordDict)
        {
            _wordDict = new List<string>(wordDict);
            return WordBreakInternal(s);
        }

        private bool WordBreakInternal(string s)
        {
            if (s.Length == 0)
                return true;
            if (_failed.Contains(s))
                return false;

            foreach (var word in _wordDict)
            {
                if (s.StartsWith(word) && WordBreakInternal(s.Substring(word.Length)))
                    return true;
            }
            _failed.Add(s);
            return false;
        }
    }
}
