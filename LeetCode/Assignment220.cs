using System;
using System.Collections.Generic;

public class Assignment220
{
    public class Solution
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
        {

            Dictionary<int, int> bucket = new Dictionary<int, int>();

            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (i > indexDiff)
                {
                    int partitionToDelete = nums[k] / (valueDiff + 1);

                    if (nums[k] < 0)
                        partitionToDelete = partitionToDelete - 1;

                    bucket.Remove(partitionToDelete);
                    k++;
                }

                int partition = nums[i] / (valueDiff + 1);
                if (nums[i] < 0)
                    partition = partition - 1;

                if (bucket.ContainsKey(partition) || (bucket.ContainsKey(partition - 1) && Math.Abs(bucket[partition - 1] - nums[i]) <= valueDiff)
                || (bucket.ContainsKey(partition + 1) && Math.Abs(bucket[partition + 1] - nums[i]) <= valueDiff))
                    return true;
                else
                    bucket.Add(partition, nums[i]);
            }

            return false;
        }
    }
}
