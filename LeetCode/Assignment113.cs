using System;
using System.Collections.Generic;

public class Assignment113
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
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var res = new List<IList<int>>();
            var sub = new List<int>();

            if (root == null)
                return res;


            return FindPaths(root, targetSum, res, sub);
        }

        public IList<IList<int>> FindPaths(TreeNode root, int targetSum, List<IList<int>> res, List<int> sub)
        {
            sub.Add(root.val);
            if (root.right == null && root.left == null && targetSum == root.val)
            {
                res.Add(new List<int>(sub));
                return res;
            }
            if (root.left != null)
            {
                FindPaths(root.left, targetSum - root.val, res, sub);
                sub.RemoveAt(sub.Count - 1);
            }
            if (root.right != null)
            {
                FindPaths(root.right, targetSum - root.val, res, sub);
                sub.RemoveAt(sub.Count - 1);
            }
            return res;
        }
    }
}
