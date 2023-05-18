using System;
using System.Collections.Generic;

public class Assignment18
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, long target)
        {
            var result = new List<IList<int>>();

            Array.Sort(nums);
            if (nums != null && nums[0] > 0 && nums[0] > target) return result;
  
            for (int i = 0; i < nums.Length - 3; i++)
            {
                while (i > 0 && i <= nums.Length - 3 && nums[i] == nums[i - 1])
                {
                    i++;
                }
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    while (j > i + 1 && j <= nums.Length - 2 && nums[j] == nums[j - 1]) j++;

                    long k = target - (nums[i] + nums[j]);
                    long low = j + 1, high = nums.Length - 1;

                    while (low < high)
                    {
                        long diff = nums[low] + nums[high];

                        if (diff < k) low++;

                        else if (diff > k) high--;

                        else
                        {
                            long sum = nums[i] + nums[j] + nums[low] + nums[high];
                            if (sum == target)
                            {
                                result.Add(new List<int>() { nums[i], nums[j], nums[low], nums[high] });
                                low++;
                                high--;
                            }
                            while (low < high && nums[low] == nums[low - 1]) low++;
                            while (low < high && nums[high] == nums[high + 1]) high--;

                        }
                    }
                }
            }

            return result;

        }
    }
