using System;
using System.Collections.Generic;
using System.Text;

public class Assignment166
{
    public class Solution
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            bool isNeg = true;
            if ((numerator < 0 && denominator < 0) || 
                (numerator > 0 && denominator > 0) || 
                numerator == 0)
                isNeg = false;

            StringBuilder sb = new StringBuilder();
            if (isNeg)
                sb.Append("-");

            long num = Math.Abs((long)numerator);
            long den = Math.Abs((long)denominator);

            sb.Append(num / den);
            num %= den;

            if (num > 0)
            {
                Dictionary<double, int> d = new Dictionary<double, int>();
                sb.Append(".");

                while (num > 0 && (!d.ContainsKey(num)))
                {
                    d.Add(num, sb.Length);
                    num *= 10;
                    sb.Append(num / den);
                    num %= den;
                }

                if (d.ContainsKey(num))
                {
                    sb.Insert(d[num], '(');
                    sb.Append(")");
                }
            }

            return sb.ToString();
        }
    }
}
