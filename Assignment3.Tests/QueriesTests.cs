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
            List<String> expected = new List<string> { "Harry Potter", "Albus Dumbledore", "Lord Voldemort", "Gellert Grindlewald" };

            IEnumerable<String> listOfWizards = query.getWizardsByAuthorExtension(input);

            Assert.Equal(expected, listOfWizards);
        }

        [Fact]
        public void Linq_WizardsByRowling()
        {
            var input = "Rowling";
            var query = new Queries();
            List<String> expected = new List<string> { "Harry Potter", "Albus Dumbledore", "Lord Voldemort", "Gellert Grindlewald" };

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

        [Fact]
        public void Extenstion_ReturnsTupleOfHarryPotter()
        {
            //Given

            //When
            var output = new Queries().getHarryPotterWizardsTupleExtension();
            //Then
            var expected = new List<(string, int?)> { ("Harry Potter", 1997), ("Albus Dumbledore", 1997), ("Lord Voldemort", 1997) };
            Assert.Equal(expected, output);
        }
        [Fact]
        public void Linq_ReturnsTupleOfHarryPotter()
        {
            //Given

            //When
            var output = new Queries().getHarryPotterWizardsTupleLinq();
            //Then
            var expected = new List<(string, int?)> { ("Harry Potter", 1997), ("Albus Dumbledore", 1997), ("Lord Voldemort", 1997) };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Extenstion_returns_wizard_names_grouped_by_creator()
        {
            //Given
            //When
            var output = new Queries().getListOfWizardsByCreatorExtensions();
            //Then
            var expected = new List<string> { "Sauron", "Gandalf", "Lord Voldemort", "Harry Potter", "Gellert Grindlewald", "Albus Dumbledore", "The red woman", "Yoda", "Darth Vader", "Jaina Proudmoore" };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Linq_returns_wizard_names_grouped_by_creator()
        {
            //Given
            //When
            var output = new Queries().getListOfWizardsByCreatorLinq();
            //Then
            var expected = new List<string> { "Sauron", "Gandalf", "Lord Voldemort", "Harry Potter", "Gellert Grindlewald", "Albus Dumbledore", "The red woman", "Yoda", "Darth Vader", "Jaina Proudmoore" };
            Assert.Equal(expected, output);
        }
    }
}
