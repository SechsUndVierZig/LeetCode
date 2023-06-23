using System;

public class Assignment108
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return CreateNode(0, nums.Length - 1);

            TreeNode CreateNode(int left, int right)
            {
                if (left > right)
                    return null;
                int mid = left + (right - left) / 2;
                return new TreeNode(nums[mid], CreateNode(left, mid - 1), CreateNode(mid + 1, right));
            }
        }
    }
}
