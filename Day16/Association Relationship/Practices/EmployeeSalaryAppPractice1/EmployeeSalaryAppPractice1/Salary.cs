using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryAppPractice1
{
    public class Salary
    {
        public double Basic { set; get; }
        public double Medical { set; get; }
        public double Conveyance { set; get; }
        public int increase;

        public Salary()
        {
            increase = 0;
        }

        public double CalculateMedicalAmount(double amount)
        {
            return (Basic * amount / 100);
        }
        public double CalculateConveyanceAmount(double amount)
        {
            return (Basic * amount / 100);
        }
        public void CalculateIncreaseAmount(double amount)
        {
            Basic += (Basic * amount / 100);
        }

        public double GetTotal()
        {
            return (Basic + Medical + Conveyance);
        }
    }
}
