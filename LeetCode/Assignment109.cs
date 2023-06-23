using System;
using System.Collections.Generic;

public class Assignment109
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
        public TreeNode SortedListToBST(ListNode head)
        {
            List<int> values = new List<int>();
            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }
            return CreateSortedListToBSTNode(values, 0, values.Count - 1);
        }

        TreeNode CreateSortedListToBSTNode(List<int> values, int start, int end)
        {
            if (start < 0 || end >= values.Count || start > end)
                return null;

            int mid = (start + end) / 2;
            return new TreeNode(values[mid], CreateSortedListToBSTNode(values, start, mid - 1), CreateSortedListToBSTNode(values, mid + 1, end));
        }
    }
}
