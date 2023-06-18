using System;

public class Assignment99
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
        public void RecoverTree(TreeNode root)
        {
            TreeNode prev = null; // prev node on treverse

            TreeNode c1 = null; // candidates to swap
            TreeNode c2 = null;

            Traverse(root);

            (c1.val, c2.val) = (c2.val, c1.val);

            return;

            void Traverse(TreeNode n)
            {
                if (n == null) return;

                Traverse(n.left);

                if (prev != null && prev.val > n.val)
                {
                    c1 = c1 ?? prev;
                    c2 = n;
                }

                prev = n;

                Traverse(n.right);
            }
        }
    }
}
