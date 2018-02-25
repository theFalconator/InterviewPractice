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
    }
}
