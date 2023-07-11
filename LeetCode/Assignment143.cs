using System;

public class Assignment143
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
        public void ReorderList(ListNode head)
        {
            ListNode slow = head, fast = head.next;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            ListNode right = slow.next, left = head;

            slow.next = null;

            ListNode prev = null, curr = right;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            right = prev;

            while (right != null)
            {
                ListNode leftTemp = left.next, rightTemp = right.next;
                left.next = right;
                right.next = leftTemp;

                left = leftTemp;
                right = rightTemp;
            }


        }
    }
}
