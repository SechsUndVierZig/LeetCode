using System;

public class Assignment58
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var endIndex = s.Length - 1;
            while (endIndex >= 0 && s[endIndex] == ' ')
                endIndex--;
            var startIndex = endIndex;
            while (startIndex >= 0 && s[startIndex] != ' ')
                startIndex--;
            return endIndex - startIndex;
        }
    }
}
