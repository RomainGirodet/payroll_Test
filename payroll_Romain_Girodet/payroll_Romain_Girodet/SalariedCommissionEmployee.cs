using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll_Romain_Girodet
{
    class SalariedCommissionEmployee :CommissionEmployee
    {
        string firstName;
        string lastName;
        string socialSecurityNumber;

        int type;


        int salary;

        int sales;
        double commissionRate;
        double commission;

        double totalEarn;

        public SalariedCommissionEmployee(string firstName, string lastName, string  socialSecurityNumber, int type, double comissionRate, int sales, int salary)
        :base(firstName,lastName,socialSecurityNumber,type,comissionRate,sales)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;

            this.type = type;

            this.commissionRate = comissionRate;
            this.sales = sales;
            this.commission = this.sales * this.commissionRate;

            this.salary = salary;

            this.totalEarn = this.commission+this.salary;

        }
        public double raiseSalary(int pourcentage)
        {
            while(pourcentage<0 )
            {
                Console.WriteLine("poucentage has to be supérior to 0, write it again ");
                pourcentage = Convert.ToInt32(Console.ReadLine());
            }
            salary = salary * (1 + (pourcentage / 100));
            return (salary);
        }
    }
}
