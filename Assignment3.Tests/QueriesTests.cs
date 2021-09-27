using System;
using Xunit;
using System.Collections.Generic;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Extension_WizardsByRowling()
        {
            var input = "Rowling";
            var query = new Queries();
            List<String> expected = new List<string>{"Harry Potter", "Albus Dumbledore", "Lord Voldemort", "Gellert Grindlewald"};

            IEnumerable<String> listOfWizards = query.getWizardsByAuthorExtension(input);

            Assert.Equal(expected, listOfWizards);
        }

        [Fact]
        public void Linq_WizardsByRowling()
        {
            var input = "Rowling";
            var query = new Queries();
            List<String> expected = new List<string>{"Harry Potter", "Albus Dumbledore", "Lord Voldemort", "Gellert Grindlewald"};

            IEnumerable<String> listOfWizards = query.getWizardsByAuthorLinq(input);

            Assert.Equal(expected, listOfWizards);
        }

        [Fact]
        public void Extension_FindFirstSithLordYear()
        {
            var query = new Queries();
            var expected = 1977;

            Assert.Equal(expected, query.getFirstSithLordYearExtension());
        }

        [Fact]
        public void Linq_FindFirstSithLordYear()
        {
            var query = new Queries();
            var expected = 1977;

            Assert.Equal(expected, query.getFirstSithLordYearLinq());
        }
    }
}
