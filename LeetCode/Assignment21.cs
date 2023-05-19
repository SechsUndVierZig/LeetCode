using System;

public class Assignment21
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode merged = null;
            ListNode tail = merged;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    ListNode newNode = new ListNode(list1.val);
                    if (merged == null)
                        merged = newNode;
                    else
                        tail.next = newNode;
                    tail = newNode;
                    list1 = list1.next;
                }
                else
                {
                    ListNode newNode = new ListNode(list2.val);
                    if (merged == null)
                        merged = newNode;
                    else
                        tail.next = newNode;
                    tail = newNode;
                    list2 = list2.next;
                }
            }

            if (list1 != null)
            {
                if (merged == null)
                    merged = list1;
                else
                    tail.next = list1;
            }

            if (list2 != null)
            {
                if (merged == null)
                    merged = list2;
                else
                    tail.next = list2;
            }

            tail = null;
            list1 = null;
            list2 = null;

            return merged;
        }
    }
}
