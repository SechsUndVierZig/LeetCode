using System;

public class Assignment234
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
        public bool IsPalindrome(ListNode head)
        {
            bool isPali = true;

            Stack ReverseNode = new Stack();
            Queue StraightNode = new Queue();
            ListNode currentNode = head;

            while (currentNode != null)
            {
                ReverseNode.Push(currentNode.val);
                StraightNode.Enqueue(currentNode.val);
                currentNode = currentNode.next;
            }

            while (ReverseNode.Count > 0)
            {
                if (ReverseNode.Peek().Equals(StraightNode.Peek()))
                {
                    ReverseNode.Pop();
                    StraightNode.Dequeue();
                }
                else
                {
                    return false;
                }
            }


            return isPali;
        }
    }
}
