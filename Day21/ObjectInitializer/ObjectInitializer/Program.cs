using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee _employee = new Employee()
            {
                Id = 1,
                Name = "Shahadat",
                Address = "Shani Akhra"
            };

           // Console.WriteLine("Id: " + _employee.Id + " Name: " + _employee.Name + " Address: " + _employee.Address);

            List<Employee> _employees = new List<Employee>()
            {
                _employee,
                new Employee(){Id=2, Name="Arman", Address="Shamoly"},
                new Employee(){Id=3, Name="Sanjoy", Address="Shanti Nagar"}
            };

            foreach (var employee in _employees)
            {
                Console.WriteLine("Id: " + employee.Id + " Name: " + employee.Name + " Address: " + employee.Address);
            }
            Console.Read();
        }
    }
}
