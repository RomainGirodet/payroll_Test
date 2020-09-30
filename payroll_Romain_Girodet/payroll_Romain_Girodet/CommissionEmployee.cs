using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll_Romain_Girodet
{
    
        class CommissionEmployee : Employee
        {
            string firstName;
            string lastName;
            string  socialSecurityNumber;

            int type;

            double commission;
            double commissionRate;
            int sales;
           


            public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, int type, double commissionRate, int sales)
            :base(firstName,lastName,socialSecurityNumber)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.socialSecurityNumber = socialSecurityNumber;
                this.type = type;

                this.commissionRate = commissionRate;
                this.sales = sales;
                this.commission = this.sales * this.commissionRate;


            }
        }
    
}
