using System;

namespace Questions
{
    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }

    }

    public class AddTwoHugeNumbers
    {
        public ListNode<int> Reverse(ListNode<int> head)
        {
            ListNode<int> prev = null;
            while (head != null)
            {
                var temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }

            return prev;
        }



        public ListNode<int> addTwoHugeNumbers(ListNode<int> a, ListNode<int> b)
        {
            return new ListNode<int>
            {
                value = a.value + b.value,
                next = null
            };
        }
    }
}
