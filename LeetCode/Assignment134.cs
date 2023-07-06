using System;

public class Assignment134
{
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int sum = gas[^1] - cost[^1];
            int maxIndex = gas.Length - 1;
            int maxSum = sum;

            for (int i = gas.Length - 2; i >= 0; i--)
            {
                sum += gas[i] - cost[i];
                if (sum > maxSum)
                {
                    maxIndex = i;
                    maxSum = sum;
                }
            }

            if (sum < 0) return -1;
            return maxIndex;
        }
    }
}
