using System;
using System.Linq;

public class Assignment125
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var clean = s.ToLower().Where(x => char.IsLetterOrDigit(x));
            return clean.Reverse().SequenceEqual(clean);
        }
    }
}
