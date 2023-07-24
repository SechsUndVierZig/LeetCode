using System;
using System.Collections.Generic;

public class Assignment173
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
    public class BSTIterator
    {

        List<int> values = new List<int>();

        public BSTIterator(TreeNode root)
        {
            PreOrder(root, values);
        }

        public int Next()
        {
            if (values.Any())
            {
                var temp = values[0];
                values.RemoveAt(0);
                return temp;
            }
            return 0;
        }

        public bool HasNext()
        {

            return values.Any();
        }

        private void PreOrder(TreeNode root, List<int> values)
        {
            if (root != null)
            {
                PreOrder(root.left, values);

                values.Add(root.val);
                PreOrder(root.right, values);

            }
            return;
        }
    }

    /**
     * Your BSTIterator object will be instantiated and called as such:
     * BSTIterator obj = new BSTIterator(root);
     * int param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}
