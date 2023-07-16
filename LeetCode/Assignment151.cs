using System;
using System.Linq;

public class Assignment151
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            return String.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}
