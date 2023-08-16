using System;

public class Assignment222
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
        public int CountNodes(TreeNode root)
        {
            var count = 0;
            if (root == null)
                return count;

            count++;
            if (root.right != null)
                count += CountNodes(root.right);
            if (root.left != null)
                count += CountNodes(root.left);
            return count;
        }
    }
}
