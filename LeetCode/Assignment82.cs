using System;

public class Assignment82
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            var dummyHead = new ListNode(int.MinValue, head);
            var prev = dummyHead;

            while (prev.next != null && prev.next.next != null)
            {
                var cur = prev.next;

                if (cur.val == cur.next.val)
                {
                    while (prev.next != null && prev.next.val == cur.val) prev.next = prev.next.next;
                }
                else prev = cur;
            }

            return dummyHead.next;
        }
    }
}
