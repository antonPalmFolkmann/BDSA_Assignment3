using System;
using Xunit;
using System.Linq;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        [Theory]
        [InlineData("Goddav, hvordan er din dag?", "?gad nid re nadrovh ,vaddoG")]
        [InlineData("Hello", "olleH")]
        public void reverse_string(string input, string expected)
        {
            string reverse(string text) => new String(text.Reverse().ToArray());
            
            var output = reverse(input);
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData(5,5, 25)]
        [InlineData(5,10, 50)]
        public void returns_product(int input1, int input2, int expected)
        {
            int product(int x, int y) => x*y;

            var output = product(input1,input2);
            Assert.Equal(expected, output);
        }
    }
}
