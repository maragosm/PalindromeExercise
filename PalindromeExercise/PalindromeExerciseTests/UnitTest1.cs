using System;
using Xunit;

namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Michael", false)]
        [InlineData("kayak", true)]
        [InlineData("madam", true)]
        [InlineData("mAdam", true)]
        public void PalindromeTester(string word, bool expected)
        {
            var tester = new Wordsmith();
            var actual = tester.PalindromeTester(word);
            Assert.Equal(expected, actual);
        }
    }
}
