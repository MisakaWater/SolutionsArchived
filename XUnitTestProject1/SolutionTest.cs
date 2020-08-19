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
        // [Fact]
        // public void MaxSlidingWindow()
        // {
        //     var sut = new Solutions.Solution();
        //     var result = sut.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
        //     Assert.Equal(new int[] {3, 3, 5, 5, 6, 7},result);
        // }
        [Fact]
        public void ArrangeCoins()
        {
            var sut = new Solutions.Solution();
            var result = sut.ArrangeCoins(21);
            Assert.Equal(6, result);
        }
        [Fact]
        public void ReverseWords()
        {
            var sut = new Solutions.Solution();
            var result = sut.ReverseWords("the sky is blue");
            Assert.Equal("blue is sky the", result);
        }

        [Fact]
        public void CheckRecord()
        {
            var sut = new Solutions.Solution();
            var result = sut.CheckRecord("PPALALLLP");
            Assert.Equal(false, result);

        }
        [Fact]
        public void HammingWeight()
        {
            var sut = new Solutions.Solution();
            var result = sut.HammingWeight(0b0000001111);
            Assert.Equal(4, result);
        }
        [Fact]
        public void TwoSum()
        {
            var sut = new Solutions.Solution();
            var result = sut.TwoSum(new int[] { 2, 7, 3, 8 }, 9);
            Assert.Equal(new int[] { 0, 1 }, result);
        }
        [Fact]
        public void ReverseWords557()
        {
            var sut = new Solutions.Solution();
            var result = sut.ReverseWords557("the sky is blue");
            Assert.Equal("eht yks si eulb", result);
        }
        [Fact]
        public void CountOdds()
        {
            var sut = new Solutions.Solution();
            var result = sut.CountOdds(8, 10);
            Assert.Equal(1, result);
        }
        [Fact]
        public void FindRepeatNumber()
        {
            var sut = new Solutions.Solution();
            var result = sut.FindRepeatNumber(new int[]{2, 3, 1, 0, 2, 5, 3});
            Assert.Equal(2, result);
        }
        [Fact]
        public void RunningSum()
        {
            var sut = new Solutions.Solution();
            var result = sut.RunningSum(new int[] { 3, 1, 2, 10, 1 });
            Assert.Equal(new int[]{3,4,6,16,17}, result);
        }
    }
}
