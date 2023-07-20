using System;

public class Assignment160
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var lengthA = GetListNodeLength(headA);
            var lengthB = GetListNodeLength(headB);

            while (lengthA > lengthB)
            {
                headA = headA.next;
                lengthA--;
            }

            while (lengthB > lengthA)
            {
                headB = headB.next;
                lengthB--;
            }

            while (headA != headB)
            {
                headA = headA.next;
                headB = headB.next;
            }

            return headA;
        }

        private static int GetListNodeLength(ListNode node)
        {
            var length = 0;

            while (node != null)
            {
                node = node.next;
                length++;
            }

            return length;
        }
    }
}
}
