using System;
using System.Collections.Generic;

public class Assignment98
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
        public bool IsValidBST(TreeNode root)
        {
            int? l = null;
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode cur = root;
            while (cur != null || s.Count() > 0)
            {
                while (cur != null)
                {
                    s.Push(cur);
                    cur = cur.left;
                }
                cur = s.Pop();
                if (l != null && l >= cur.val) return false;
                l = cur.val;
                cur = cur.right;
            }

            return true;
        }
    }
}
