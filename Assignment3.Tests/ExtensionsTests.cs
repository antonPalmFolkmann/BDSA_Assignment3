using System;
using Xunit;

namespace BDSA2020.Assignment02.Tests
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

            Assert.Equal(output, expected);
        }
        
    }
}
