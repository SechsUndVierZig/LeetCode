using System;
using System.Collections.Generic;

public class Assignment205
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> sToT = new Dictionary<char, char>();
            Dictionary<char, char> tToS = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];

                if (sToT.ContainsKey(sChar))
                {
                    if (sToT[sChar] != tChar)
                        return false;
                }
                else if (tToS.ContainsKey(tChar))
                {
                    if (tToS[tChar] != sChar)
                        return false;
                }
                else
                {
                    sToT[sChar] = tChar;
                    tToS[tChar] = sChar;
                }
            }

            return true;
        }
    }
}
