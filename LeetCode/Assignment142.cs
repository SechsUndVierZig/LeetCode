using System;
using System.Collections.Generic;

public class Assignment142
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            var set = new HashSet<ListNode>();

            while (head != null)
            {
                if (set.Contains(head))
                    break;

                set.Add(head);
                head = head.next;
            }

            return head;
        }
    }
}
