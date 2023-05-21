using System;

public class Assignment29
{
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0) return Int32.MaxValue;
            int sum = 0;
            try
            {
                sum = dividend / divisor;
                return sum;
            }
            catch (OverflowException)
            {
                if (sum < Int32.MinValue) return Int32.MinValue;
                else return Int32.MaxValue;
            }
        }
    }
}
