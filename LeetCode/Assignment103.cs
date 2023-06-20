using System;
using System.Collections.Generic;

public class Assignment103
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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> ret = new();
            if (root == null) return ret;
            ZigzagLevelOrderSub(root, ret, 0);
            return ret;
        }
        private void ZigzagLevelOrderSub(TreeNode nd, List<IList<int>> ret, int level)
        {
            if (ret.Count < level + 1) ret.Add(new List<int>());
            if (level % 2 == 0)
                ret[level].Add(nd.val);
            else
                ret[level].Insert(0, nd.val);

            if (nd.left != null) ZigzagLevelOrderSub(nd.left, ret, level + 1);
            if (nd.right != null) ZigzagLevelOrderSub(nd.right, ret, level + 1);
        }
    }
}
