namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] l1 = { 2, 4, 3 };
            int[] l2 = { 5, 6, 4 };

            Array.Reverse(l1);
            Array.Reverse(l2);
            string f1 = "";
            string f2 = "";

            foreach(int i in l1)
            {
                f1 += i.ToString();
            }
            foreach(int i in l2)
            {
                f2 += i.ToString();
            }
            Console.WriteLine(Int32.Parse(f1) + Int32.Parse(f2));
            int[] result = (Int32.Parse(f1) + Int32.Parse(f2)).ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}