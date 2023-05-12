using System;

public class ThirdAssignment
{
    public class Solution3
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = new int[nums1.Length + nums2.Length];

            nums1.CopyTo(nums3, 0);
            nums2.CopyTo(nums3, nums1.Length);

            int n = nums3.Length;
            Array.Sort(nums3);

            if (n % 2 != 0)
                return (double)nums3[n / 2];

            return (double)(nums3[(n - 1) / 2] + nums3[n / 2]) / 2.0;
        }
    }
}
