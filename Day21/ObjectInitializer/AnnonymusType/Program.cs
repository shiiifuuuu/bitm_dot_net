using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectInitializer;

namespace AnnonymusType
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee { Id=1, Name = "Ali", Address = "Motijheel" };

            var customer = new {Id = 1, Name = "Ali", Address = "Motijheel"};

            var customers = new[]
            {
                new {Id = 1, Name = "Ali", Address = "Motijheel"},
                new {Id = 2, Name = "Alim", Address = "Jatrabari"},
                new {Id = 3, Name = "Alo", Address = "Rayerbag"}
            };

            //Show(customers);

            Action showAction = Show;
            showAction();

            Func<int,int,int> AddAction = Add;
            Console.WriteLine("Sum: " + AddAction(10, 20));
            Console.Read();
        }

        static void Show()
        {
            Console.WriteLine("Function with no argument called!");
        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }


        static void Show(dynamic customers)
        {

            foreach (var cust in customers)
            {
                Console.WriteLine("Id: " + cust.Id + " Name: " + cust.Name + " Address: " + cust.Address);
            }

            Console.Read();
        }
    }
}
