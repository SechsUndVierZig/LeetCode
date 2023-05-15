using System;

public class Assignment8
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            var index = 0;
            while (index < s.Length && char.IsWhiteSpace(s[index]))
            {
                ++index;
            }
            var sign = 1;
            if (index < s.Length && (s[index] == '-' || s[index] == '+'))
            {
                if (s[index] == '-')
                {
                    sign = -1;
                }
                ++index;
            }
            var result = 0;
            while (index < s.Length && char.IsDigit(s[index]))
            {
                var digit = CharToInt(s[index]);
                if (result > (int.MaxValue - digit) / 10)
                {
                    return sign == -1 ? int.MinValue : int.MaxValue;
                }
                result = (result * 10) + digit;
                ++index;
            }
            return result * sign;
        }
        private static int CharToInt(char ch)
        {
            return ch - '0';
        }
    }
}
