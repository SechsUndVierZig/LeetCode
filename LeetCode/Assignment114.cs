using System;

public class Assignment114
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
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            flatten(root);
        }

        private TreeNode flatten(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return root;

            if (root.left == null || root.right == null)
            {
                if (root.right == null)
                    moveLeftToRight(root);

                return flatten(root.right);
            }

            TreeNode lastLeft = flatten(root.left);
            TreeNode lastRight = flatten(root.right);
            TreeNode tempRight = root.right;

            moveLeftToRight(root);
            lastLeft.right = tempRight;

            return lastRight;
        }

        private void moveLeftToRight(TreeNode root)
        {
            root.right = root.left;
            root.left = null;
        }
    }
}
