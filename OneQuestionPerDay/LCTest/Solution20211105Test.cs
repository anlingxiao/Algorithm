namespace LCTest
{
    using OneQuestionPerDay;
    using System;
    using Xunit;

    public class Solution20211105Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution20211105();
            var sut = solution.LongestSubsequence(new int[] { 18, 18, -18, 8, -23, -13, -9, 23, -14, -16, 12, -12, 3, 13, 10, 8, -6, -19, 9, 6, 2, 13, 22, 19 }, -23);
            Assert.Equal(1, sut);
        }
    }
}
