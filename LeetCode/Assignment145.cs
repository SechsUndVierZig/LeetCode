using System;
using System.Collections.Generic;

public class Assignment145
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
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            List<int> result = new List<int>();
            if (root.left != null)
            {
                result.AddRange(PostorderTraversal(root.left));
            }
            if (root.right != null)
            {
                result.AddRange(PostorderTraversal(root.right));
            }
            result.Add(root.val);

            return result;
        }
    }
}
