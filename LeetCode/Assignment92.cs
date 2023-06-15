using System;

public class Assignment92
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
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == right)
                return head;

            ListNode prev = null;
            ListNode pres = head;
            ListNode next = head.next;
            int count = 1;
            while (count < left)
            {
                prev = pres;
                pres = next;
                next = next.next;
                count++;
            }

            ListNode newEnd = pres;
            ListNode last = prev;
            while (count < right)
            {
                ListNode p = next.next;
                pres.next = prev;
                next.next = pres;
                prev = pres;
                pres = next;
                next = p;
                count++;
            }

            newEnd.next = next;

            if (last == null) return pres;

            last.next = pres;
            return head;
        }
    }
}
