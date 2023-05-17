using System;

public class Assisgnment16
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var result = 0;
            var closestDifference = int.MaxValue;
            Array.Sort(nums);

            for (int index = 0; index < nums.Length; ++index)
            {
                if (index > 0 && nums[index] == nums[index - 1]) continue;

                var startIndex = index + 1;
                var endIndex = nums.Length - 1;
                while (startIndex < endIndex)
                {
                    var sum = nums[index] + nums[startIndex] + nums[endIndex];

                    var difference = Math.Abs(target - sum);
                    if (difference < closestDifference)
                    {
                        closestDifference = difference;
                        result = sum;
                    }
                    if (difference == 0) break;
                    else if (sum < target) ++startIndex;
                    else --endIndex;
                }
                if (closestDifference == 0) break;
            }
            return result;
        }
    }
}
