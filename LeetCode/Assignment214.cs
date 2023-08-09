using System;

public class Assignment214
{
    public class Solution
    {
        public string ShortestPalindrome(string s)
        {
            int n = s.Length;
            int i = 0;
            for (int j = n - 1; j >= 0; j--)
                if (s[i] == s[j])
                    i++;
            if (i == n)
                return s;
            string r = s.Substring(i, n - i);
            string rev = r;

            char[] ch = rev.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            Console.WriteLine(rev);
            return rev + ShortestPalindrome(s.Substring(0, i)) + r;

        }
    }
}
