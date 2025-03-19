using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    public class Insurer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Insurer(string firstName, string lastName, int age, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, věk: {Age}, telefon: {Phone}";
        }
    }
}
