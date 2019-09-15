using PalindromesExercise;
using System;
using Xunit;

namespace Palindromes.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PalindromeTests()
        {
            // Arrange
            var word = "muh";
            var runWord = new Word();

            // Act
            var result = runWord.RunWord(word);

            // Assert
            Assert.True(result);
        }
    }
}
