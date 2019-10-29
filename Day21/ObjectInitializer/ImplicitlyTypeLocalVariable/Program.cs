using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectInitializer;

namespace ImplicitlyTypeLocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            var num2 = 20;

            List<Employee> _employeeList = new List<Employee>();
            var _employees = new List<Employee>();

            var _employee = new Employee();
        }
    }
}
