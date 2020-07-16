using System;
using Xunit;

namespace Solutions_CSharp_Tests
{
    public class SolutionTest
    {
        [Fact]
        public void IsPalindrome()
        {
            var sut = new Solutions.Solution();
            var result = sut.IsPalindrome(1551);
            Assert.True(result);
        }
        [Fact]
        public void MaxSlidingWindow()
        {
            var sut = new Solutions.Solution();
            var result = sut.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            Assert.Equal(new int[] {3, 3, 5, 5, 6, 7},result);
        }
    }
}
