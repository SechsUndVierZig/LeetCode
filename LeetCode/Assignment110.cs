using System;

public class Assignment110
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
        private bool res = true;
        public bool IsBalanced(TreeNode root)
        {

            if (root == null)
                return true;
            DFS(root, 0);

            return res;
        }

        private int DFS(TreeNode node, int h)
        {

            if (node == null)
                return 0;

            int lh = DFS(node.left, h + 1),
            rh = DFS(node.right, h + 1);

            if (Math.Abs(lh - rh) > 1)
                res = false;

            return Math.Max(lh, rh) + 1;
        }
    }
}
