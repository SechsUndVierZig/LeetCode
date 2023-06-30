using System;

public class Assignment124
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
        public int MaxPathSum(TreeNode root)
        {
            int maxSum = int.MinValue;
            Traverse(root, ref maxSum);
            return maxSum;
        }

        private int Traverse(TreeNode node, ref int maxSum)
        {
            if (node == null)
                return 0;

            int leftSum = Math.Max(0, Traverse(node.left, ref maxSum));
            int rightSum = Math.Max(0, Traverse(node.right, ref maxSum));

            int pathSum = leftSum + rightSum + node.val;
            maxSum = Math.Max(maxSum, pathSum);

            return Math.Max(leftSum, rightSum) + node.val;
        }
    }
}
