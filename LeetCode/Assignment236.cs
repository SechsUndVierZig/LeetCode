using System;

public class Assignment236
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class Solution
    {

        bool found = false;
        public void FindPath(TreeNode root, TreeNode p, List<TreeNode> list)
        {
            if (root == null) return;
            list.Add(root);
            if (root.val == p.val) found = true;
            if (found != true)
                FindPath(root.left, p, list);
            if (found != true)
                FindPath(root.right, p, list);
            if (found != true)
                list.Remove(root);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            List<TreeNode> list1 = new List<TreeNode>();
            FindPath(root, p, list1);
            List<TreeNode> list2 = new List<TreeNode>();
            found = false;
            FindPath(root, q, list2);

            if (list1.Count == 0 || list2.Count == 0) return null;

            int count = Math.Min(list1.Count, list2.Count);
            int i;
            for (i = 0; i < count; i++)
                if (list1[i] != list2[i]) break;

            if (i - 1 < 0) return null;

            return list1[i - 1];

        }
    }
}
