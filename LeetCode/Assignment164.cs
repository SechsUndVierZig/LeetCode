using System;

public class Assignment164
{
    public class Solution
    {
        public int MaximumGap(int[] nums)
        {
            if (nums.Length < 2)
                return 0;
            var queue = new PriorityQueue<int, int>(nums.Select(z => (z, z)));

            var gap = 0;

            while (queue.Count != 1)
            {
                var cgap = -queue.Dequeue() + queue.Peek();
                if (gap < cgap)
                    gap = cgap;
            }

            return gap;
        }
    }
}
