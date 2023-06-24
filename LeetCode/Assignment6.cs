using System;

public class SixthAssignment
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            var arr = new char[s.Length];
            int index = 0;
            int rowIndex = 0;
            bool goingDown = true;

            if (numRows == 1)
                return s;

            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[index];
                if (goingDown)
                    index += (numRows - rowIndex - 1) * 2;
                else
                    index += rowIndex * 2;

                if (rowIndex != 0)
                    goingDown = !goingDown;
                if (index >= s.Length)
                {
                    rowIndex++;
                    index = rowIndex;
                    goingDown = true;
                    if (rowIndex == numRows - 1)
                        rowIndex = 0;
                }
            }

            return new string(arr);
        }
    }
}
