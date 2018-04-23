using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Questions.Test
{
    public class AddTwoNumbersTests
    {
        [Fact]
        public void CanReverseLists()
        {
            var adder = new AddTwoNumbers();
            var l = new ListNode(1) {next = new ListNode(2) {next = new ListNode(3)}};
            var reversed = adder.Reverse(l);
        }

        [Fact]
        public void CanAdd()
        {
            var adder = new AddTwoNumbers();
            var l1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } };
            var l2 = new ListNode(5) { next = new ListNode(6) { next = new ListNode(5) } };
            var result = adder.Add(l1, l2);
        }
    }
}
