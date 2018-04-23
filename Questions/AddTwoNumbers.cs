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
            int carry = 0;
            ListNode prev = new ListNode(0);
            ListNode head = prev;
            while (l1 != null || l2 != null || carry != 0)
            {
                var cursor = new ListNode(0);
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                
                cursor.val = sum % 10;
                carry = sum / 10;
                prev.next = cursor;
                prev = cursor;

                l1 = (l1 != null) ? l1.next : l1;
                l2 = (l2 != null) ? l2.next : l2;
            }

            return head.next;
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
