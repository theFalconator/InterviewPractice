using System;
using Xunit;

namespace Questions.Test
{
    public class AddTwoHugeNumbers
    {
        [Fact]
        public void TestListNode()
        {
            var l1 = new ListNode<int>();
            l1.value = 0;
            l1.next = null;
            
            Assert.Equal(0, l1.value);
            Assert.Null(l1.next);
        }

        [Fact]
        public void AddSingleDigitNumbersNoOverflow()
        {
            var a = new ListNode<int> {next = null, value = 1};
            var b = new ListNode<int> {next = null, value = 2};

            var result = new ListNode<int> {next = null, value = 3};

            var add = new Questions.AddTwoHugeNumbers();

            Assert.True(result.Equals(add.addTwoHugeNumbers(a,b)));
        }

        [Fact]
        public void ReverseOneDigit()
        {
            var a = new ListNode<int> {next = null, value = 1};
            var add = new Questions.AddTwoHugeNumbers();
            
            Assert.Equal(1, add.Reverse(a).value);
            Assert.Null(add.Reverse(a).next);
        }

        [Fact]
        public void ReverseTwoDigits()
        {
            var a = new ListNode<int>
            {
                next = new ListNode<int> {value = 2},
                value = 1
            };

            var add = new Questions.AddTwoHugeNumbers();
            var reversed = add.Reverse(a);
            Assert.Equal(2, reversed.value);
            Assert.Equal(1, reversed.next.value);

        }

    }
}
