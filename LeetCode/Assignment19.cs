using System;

public class Assignment19
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
        public static int Length(ListNode head)
        {
            ListNode temp = head;
            int count = 0;
            while (temp != null)                           
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public static void PrintList(ListNode head)
        {
            ListNode ptr = head;
            while (ptr != null) 
            {
                Console.Write(ptr.val + " "); 
                 ptr = ptr.next; 
            }
            Console.WriteLine(); 
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int Length = Solution.Length(head); 
            int nodeFromBeginning= Length - n + 1;
            ListNode prev = null;
            ListNode temp = head;
            for (int i = 1; i < nodeFromBeginning;i++) 
            {
                prev = temp;
                temp = temp.next;
            }
            if (prev == null) 
            {
                head = head.next; 
                return head; 
            }
            else 
            {
                prev.next = prev.next.next; 
                return head; 
            }
        }
    
}
