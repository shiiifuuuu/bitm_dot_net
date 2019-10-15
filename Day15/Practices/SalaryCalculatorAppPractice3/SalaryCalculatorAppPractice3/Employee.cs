using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    public class Employee
    {
        public string Name { set; get; }
        public double Salary { set; get; }

        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public double ShowTotalSalary(int homeRent, int medicalAllowance)
        {
            double totalSalary = 0;
            double home = Salary * homeRent/ 100;
            double medical = Salary * medicalAllowance / 100;
            totalSalary = Salary + home + medical;
            return totalSalary;
        }
    }
}
