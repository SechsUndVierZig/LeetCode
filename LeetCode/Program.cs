using System.Runtime.CompilerServices;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1534236469;
            var reverse = string.Join("", Math.Abs(start).ToString().Reverse());
            Console.WriteLine (Convert.ToInt32(double.Parse(reverse) * Math.Sign(start)));
        }
    }
}