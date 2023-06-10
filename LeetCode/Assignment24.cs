using System;

public class Assignment24
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var newhead = head.next;
            head.next = SwapPairs(head.next.next);
            newhead.next = head;
            return newhead;
        }
    }
}
