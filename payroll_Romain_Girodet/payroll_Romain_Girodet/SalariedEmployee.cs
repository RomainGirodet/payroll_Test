using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll_Romain_Girodet
{
    class SalariedEmployee :Employee
    {
        string firstName;
        string lastName;
        string  socialSecurityNumber;

        int type;

        int salary;

        public SalariedEmployee(string firstName, string lastName, string  socialSecurityNumber, int type, int salary)
            :base(lastName,firstName,socialSecurityNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
            this.type = type;
            this.salary = salary;
        }
    }
}
