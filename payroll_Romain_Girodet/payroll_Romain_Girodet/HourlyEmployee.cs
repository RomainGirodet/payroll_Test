using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll_Romain_Girodet
{
    class HourlyEmployee : Employee
    {
        string firstName;
        string lastName;
        string socialSecurityNumber;

        int type;

        int timeWorked;
        int moneyperHours;
        double earn;

        public int TimeWorked { get { return this.timeWorked; } }

        public HourlyEmployee(string firstName, string lastName, string  socialSecurityNumber, int type, int timeWorked, int moneyperHours)
            : base(firstName,lastName,socialSecurityNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;

            this.type = type;

            this.timeWorked = timeWorked;
            this.moneyperHours = moneyperHours;
            determindEarn();
           


        }
        public void determindEarn()
        {
            if(timeWorked<=40)
            {
                earn = timeWorked * moneyperHours;
            }
            else
            {
                earn = 40 * moneyperHours + (timeWorked - 40) * (moneyperHours*1.5);
            }

            
        }
    }
}
