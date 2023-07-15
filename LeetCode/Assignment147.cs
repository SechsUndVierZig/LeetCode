using System;

public class Assignment147
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
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode sortedlist = null;
            ListNode clone = head;
            while (clone != null)
            {
                if (sortedlist == null || clone.val < sortedlist.val)
                {
                    var temp = new ListNode(clone.val, sortedlist);
                    sortedlist = temp;
                }
                else
                {
                    ListNode current = sortedlist;
                    while (current.next != null && current.next.val < clone.val)
                        current = current.next;
                    var temp = new ListNode(clone.val, current.next);
                    current.next = temp;
                }
                clone = clone.next;
            }
            return sortedlist;
        }
    }
}
