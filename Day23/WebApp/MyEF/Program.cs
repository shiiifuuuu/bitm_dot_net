using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.BLL.Manager;
using WebApp.Model.Model;

namespace MyEF
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager _studentManager = new StudentManager();

            Student student = new Student()
            {
                Address = "Kazipara", Age = 22, Name = "Saykat", RollNo = "56"
            };

            if (_studentManager.Add(student))
            {
                Console.WriteLine("Saved");
            }
            else
            {
                Console.WriteLine("Not Saved");
            }

            _studentManager.Delete(student);
            _studentManager.Update(student.Id);
            _studentManager.GetAll();
            _studentManager.GetById(student.Id);

            Console.ReadKey();
        }
    }
}
