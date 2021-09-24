using System;
using Xunit;

namespace Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Theory]
        [InlineData("https://google.com", true)]
        [InlineData("http://google.com", false)]
        public void URI_is_secure(String url, bool expected)
        {
            var input = new Uri(url);

            var output = input.isSecure();

            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData("Goddav, hvordan er din dag?", 5)]
        [InlineData("Godnat, jeg håber du får en god nat!", 8)]
        public void wordCount_returns_correct_amount(String input, int expected)
        {
            var output = input.wordCount();

            Assert.Equal(expected, output);
        }
    }
}
