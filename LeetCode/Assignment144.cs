using System;
using System.Collections.Generic;

public class Assignment144
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            PreorderTraversalRecursive(root, list);
            return list;
        }

        private void PreorderTraversalRecursive(TreeNode node, List<int> list)
        {
            if (node == null) return;
            list.Add(node.val);
            PreorderTraversalRecursive(node.left, list);
            PreorderTraversalRecursive(node.right, list);
        }
    }
}
