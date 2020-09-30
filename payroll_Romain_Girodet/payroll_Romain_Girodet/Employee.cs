using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll_Romain_Girodet
{
    class Employee
    {
        string firstName;
        string lastName;
        string  socialSecurityNumber;

        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string  SocialSecurityNumber { get { return this.socialSecurityNumber; } }


        public Employee(string firstName, string lastName, string  socialSecurityNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
            


        }
        public override string ToString()
        {
            return $"{firstName}{lastName} : {socialSecurityNumber}";
        }
        public void Earning()
        {

        }
    }
}
