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

        [Theory]
        [InlineData(5,"5", true)]
        [InlineData(5,"10", false)]
        [InlineData(42," 0042",true)]
        public void returns_number_string_equal(int input1, string input2, bool expected)
        {
            bool compareNumberString(int x, string y) => Convert.ToInt32(y) == x;

            var output = compareNumberString(input1,input2);
            Assert.Equal(expected, output);
        }
    }
}
