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
    }
}
