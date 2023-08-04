using System;
using System.Collections.Generic;

public class Assignment208
{
    public class Trie
    {
        HashSet<string> values;
        HashSet<string> keys;
        public Trie()
        {
            values = new HashSet<string>();
            keys = new HashSet<string>();
        }

        public void Insert(string word)
        {
            if (!values.Contains(word))
                values.Add(word);
            for (var i = word.Length; i > 0; i--)
            {
                if (!keys.Contains(word.Substring(0, i)))
                    keys.Add(word.Substring(0, i));
                else
                    break;// all prev string are in KEYS
            }
        }

        public bool Search(string word)
        {
            return values.Contains(word);
        }

        public bool StartsWith(string prefix)
        {
            return keys.Contains(prefix);
        }
    }
    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
