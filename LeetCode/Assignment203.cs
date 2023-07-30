using System;

public class Assignment203
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;
            ListNode root = head;
            ListNode prev = null;
            while (head != null)
            {
                if (head.val == val)
                {
                    if (prev == null)
                        root = head.next;
                    else
                        prev.next = head.next;
                    head = head.next;
                    continue;
                }
                prev = head;
                head = head.next;
            }
            return root;
        }
    }
}
