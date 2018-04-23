using System;
using System.Collections.Generic;
using System.Text;

namespace Questions
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    public class AddTwoNumbers
    {
        public ListNode Add(ListNode l1, ListNode l2)
        {
            var listnode = Reverse(l1);
            return new ListNode(1);
        }

        public ListNode Reverse(ListNode l)
        {
            Stack<ListNode> existingList = new Stack<ListNode>();
            while (l != null)
            {
                existingList.Push(l);
                l = l.next;
            }

            ListNode cursor = existingList.Pop();
            ListNode head = cursor;
            while (existingList.Count > 0)
            {
                cursor.next = existingList.Pop();
                cursor = cursor.next;
            }

            cursor.next = null;

            return head;
        }
    }
}
