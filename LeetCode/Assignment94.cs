﻿using System;
using System.Collections.Generic;

public class Assignment94
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
        IList<int> resultList = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            InorderTraversal(root.left);
            resultList.Add(root.val);
            InorderTraversal(root.right);

            return resultList;
        }
    }
}
