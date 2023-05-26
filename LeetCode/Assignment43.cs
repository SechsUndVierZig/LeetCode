using System;
using System.Numerics;

public class Assignment43
{
    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            BigInteger n = BigInteger.Parse(num1);
            BigInteger n1 = BigInteger.Parse(num2);
            BigInteger k = n * n1;
            return k.ToString();
        }
    }
}
