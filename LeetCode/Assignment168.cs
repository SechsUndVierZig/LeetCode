using System;
using System.Text;

public class Assignment168
{
    public class Solution
    {
        public string ConvertToTitle(int columnNumber)
        {
            const int BASE_26 = 26;
            var sb = new StringBuilder();
            var residuo = 0;

            while (columnNumber > 0)
            {
                columnNumber--;
                residuo = columnNumber % BASE_26;
                sb.Insert(0, GetCharacter(residuo));
                columnNumber /= BASE_26;
            }

            return sb.ToString();
        }

        private static char GetCharacter(int columnNumber) => (char)('A' + columnNumber);
    }
}
