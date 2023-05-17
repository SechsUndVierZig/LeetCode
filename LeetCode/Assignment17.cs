using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Assignment17
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (String.IsNullOrEmpty(digits))
            {
                return result;
                throw new ArgumentNullException(nameof(digits));
            }
            Dictionary<Char, char[]> lettersMap = new Dictionary<Char, char[]>();
            lettersMap.Add('1', null);
            lettersMap.Add('2', new[] { 'a', 'b', 'c' });
            lettersMap.Add('3', new[] { 'd', 'e', 'f' });
            lettersMap.Add('4', new[] { 'g', 'h', 'i' });
            lettersMap.Add('5', new[] { 'j', 'k', 'l' });
            lettersMap.Add('6', new[] { 'm', 'n', 'o' });
            lettersMap.Add('7', new[] { 'p', 'q', 'r', 's' });
            lettersMap.Add('8', new[] { 't', 'u', 'v' });
            lettersMap.Add('9', new[] { 'w', 'x', 'y', 'z' });
            lettersMap.Add('0', null);
            StringBuilder sb = new StringBuilder();
            int position = 0;
            LetterCombinationsFunction(digits, sb, lettersMap, result, position);
            return result;

        }
        private static List<String> LetterCombinationsFunction(String digits, StringBuilder sb,
                Dictionary<Char, Char[]> lettersMap, List<String> result, int pos)
        {
            if (sb.Length == digits.Count())
            {
                result.Add(sb.ToString());
                return result;
            }
            lettersMap.TryGetValue(digits[pos], out char[] values);
            foreach (var v in values)
            {
                sb.Append(v);
                LetterCombinationsFunction(digits, sb, lettersMap, result, pos + 1);
                sb.Remove(sb.Length - 1, 1);
            }
            return result;
        }
    }
}
