using System;

public class Assignment69
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            double i = 0;
            while (i * i <= x)
            {

                if ((i * i) <= x && (i + 1) * (i + 1) > x)
                    return (int)i;
                i++;
            }
            return 0;
        }
    }
}
