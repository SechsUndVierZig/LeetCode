using System;

public class Assignment33
{
    public class Solution
    {
        public int Search(int[] A, int target)
        {
            return this.SearchRecursion(A, 0, A.Length - 1, target);
        }

        private int SearchRecursion(int[] A, int low, int high, int target)
        {
            if (low > high) return -1;

            var mid = (high - low) / 2 + low;

            if (A[mid] == target) return mid;

            if (A[mid] >= A[low])
            {
                if (target >= A[low] && target < A[mid])
                    return this.SearchRecursion(A, low, mid - 1, target);

                return this.SearchRecursion(A, mid + 1, high, target);
            }
            else
            {
                if (target > A[mid] && target <= A[high])
                    return this.SearchRecursion(A, mid + 1, high, target);

                return this.SearchRecursion(A, low, mid - 1, target);
            }
        }
    }
}
