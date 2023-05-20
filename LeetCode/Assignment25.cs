using System;

public class Assignment25
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
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k == 1) return head;
            var fakehead = new ListNode(-1) { next = head };
            var start = fakehead;
            var nodeToReverse = head;
            while (true)
            {
                if (canmove(start, k) == null) break;
                var count = 1;
                while (count++ < k)
                {
                    var tmp = start.next;
                    start.next = nodeToReverse.next;
                    nodeToReverse.next = nodeToReverse.next.next;
                    start.next.next = tmp;
                }
                start = nodeToReverse;
                nodeToReverse = nodeToReverse.next;
            }
            return fakehead.next;
        }

        private ListNode canmove(ListNode head, int k)
        {
            var count = 0;
            while (count++ < k)
            {
                if (head == null) return null;
                head = head.next;
            }
            return head;
        }
    }
}
