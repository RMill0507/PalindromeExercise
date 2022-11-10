using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("palindrome", false)]
        [InlineData("mom", true)]
        [InlineData("kayak", true)]
        [InlineData("solos", true)]
        [InlineData("chewbacca", false)]

        public void IsAPalindrome(string word, bool expected)
        {
            WordSmith test = new WordSmith();

            bool actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);


        }
    }
}
