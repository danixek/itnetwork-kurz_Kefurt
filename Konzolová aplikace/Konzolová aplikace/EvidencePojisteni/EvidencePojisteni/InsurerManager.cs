using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    public class InsurerManager
    {
        private List<Insurer> insurers;

        public InsurerManager()
        {
            insurers = new List<Insurer>();
        }
        public void AddInsurer(Insurer insurer)
        {
            insurers.Add(insurer);
        }
        public List<Insurer> GetAllInsurers()
        {
            return insurers;
        }

        public List<Insurer> SearchInsurers(string firstName, string lastName) {
        return insurers.FindAll(p => p.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                                     p.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

        }
    }
}
