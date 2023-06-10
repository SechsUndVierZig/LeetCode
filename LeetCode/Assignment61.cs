using System;

public class Assignment61
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
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null || k == 0) return head;
            ListNode last = head;
            int length = 1;
            while (last.next != null)
            {
                last = last.next;
                length++;
            }
            k = k % length;
            if (k == 0) return head;

            ListNode current = head;
            for (int i = 1; i < length - k; i++) current = current.next;

            ListNode newhead = current.next;
            current.next = null;
            last.next = head;
            return newhead;
        }
    }
}
