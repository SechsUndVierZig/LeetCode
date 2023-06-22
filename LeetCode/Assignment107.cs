using System;
using System.Collections.Generic;

public class Assignment107
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();

            if (root == null) return res;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var qCount = q.Count;
                IList<int> currentLevel = new List<int>();

                while (qCount-- > 0)
                {
                    var currentNode = q.Dequeue();
                    currentLevel.Add(currentNode.val);

                    if (currentNode.left != null) q.Enqueue(currentNode.left);


                    if (currentNode.right != null) q.Enqueue(currentNode.right);

                }

                res.Insert(0, currentLevel);
            }

            return res;
        }
    }
}
