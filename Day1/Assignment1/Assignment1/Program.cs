using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, age, address, contact;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            age = Console.ReadLine();
            Console.Write("Please enter your address: ");
            address = Console.ReadLine();
            Console.Write("Please enter your contact: ");
            contact = Console.ReadLine();

            Console.WriteLine("\nOutput: ");
            Console.WriteLine("Form Information: \n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Contact: " + contact);

            Console.Write("\nPress any key to return...");
            Console.ReadKey();
        }
    }
}
