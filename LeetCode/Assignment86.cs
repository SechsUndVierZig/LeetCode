using System;
using System.Collections.Generic;

public class Assignment86
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
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            List<ListNode> list = new List<ListNode>();
            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }
            if (list.Count == 0) return null;
            else if (list.Count == 1) return list[0];
            ListNode[] nodes = new ListNode[list.Count];
            int index = 0;
            for (int i = 0; i < nodes.Length; i++)
            {
                if (list[i].val >= x) continue;
                nodes[index] = list[i];
                index++;
            }
            for (int i = 0; i < nodes.Length; i++)
            {
                if (list[i].val < x) continue;
                nodes[index] = list[i];
                index++;
            }
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i].next = (i + 1 < nodes.Length) ? nodes[i + 1] : null;
            }
            return nodes[0];
        }
    }
}
