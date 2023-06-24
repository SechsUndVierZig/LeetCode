using System;
using System.Linq;

public class SeventhAssignment
{
    public class Solution
    {
        public int Reverse(int x)
        {
            try
            {
                checked
                {
                    var reverse = string.Join("", Math.Abs(x).ToString().Reverse());
                    return int.Parse(reverse) * Math.Sign(x);
                }
            }
            catch (OverflowException e)
            {
                return 0;
            }
        }
    }
}
