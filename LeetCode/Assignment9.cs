using System;

public class Assignment9
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string firstNumber = x.ToString();
            char[] stringArray = firstNumber.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);

            return firstNumber == reversedStr ? true : false;

        }
    }
}
