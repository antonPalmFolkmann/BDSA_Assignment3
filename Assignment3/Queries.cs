using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        public IEnumerable<string> getWizardsByAuthorExtension(string author)
        {
            var wizards = Wizard.Wizards.Value;
            return wizards.Where(w => w.Creator.Contains(author)).Select(w => w.Name);
        }

        public IEnumerable<string> getWizardsByAuthorLinq(string author)
        {
            var wizards = Wizard.Wizards.Value;
            return from w in wizards
                   where w.Creator.Contains(author)
                   select w.Name;
        }

        public int? getFirstSithLordYearExtension()
        {
            var wizards = Wizard.Wizards.Value;
            return wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).First().Year;
        }

        public int? getFirstSithLordYearLinq()
        {
            var wizards = Wizard.Wizards.Value;
            return (from w in wizards
                    where w.Name.Contains("Darth")
                    orderby w.Year
                    select w.Year).First();
        }

        public IEnumerable<(string, int?)> getHarryPotterWizardsTupleExtension()
        {
            var wizards = Wizard.Wizards.Value;
            return wizards.Where(w => w.Medium.Contains("Harry Potter")).Distinct().Select(w => (w.Name, w.Year));
        }
        public IEnumerable<(string, int?)> getHarryPotterWizardsTupleLinq()
        {
            var wizards = Wizard.Wizards.Value;
            return (from w in wizards
                    where w.Medium.Contains("Harry Potter")
                    select (w.Name, w.Year)).Distinct();
        }

        public IEnumerable<string> getListOfWizardsByCreatorExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            return wizards.OrderByDescending(w => w.Creator).ThenByDescending(w => w.Name).Select(w => w.Name);
        }
        public IEnumerable<string> getListOfWizardsByCreatorLinq()
        {
            var wizards = Wizard.Wizards.Value;
            return from w in wizards
                   orderby w.Creator descending, w.Name descending
                   select w.Name;
        }
    }
}
