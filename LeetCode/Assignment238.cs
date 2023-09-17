using System;

public class Assignment238
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int number0 = 0;
            int product = 1;
            int[] answer = new int[nums.Length];

            foreach (int num in nums)
            {
                if (num == 0)
                {
                    number0++;
                    continue;
                }
                product *= num;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (number0 > 0 && nums[i] != 0 || number0 >= 2 && nums[i] == 0) answer[i] = 0;
                else if (number0 == 1 && nums[i] == 0) answer[i] = product;
                else answer[i] = product / nums[i];
            }

            return answer;
        }
    }
}
