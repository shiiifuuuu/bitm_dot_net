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

            //Student student = new Student()
            //{
            //    Address = "Dhanmondi", Age = 22, Name = "Raqib", RollNo = "95"
            //};

            //if (_studentManager.Add(student))
            //{
            //    Console.WriteLine("Saved");
            //}
            //else
            //{
            //    Console.WriteLine("Not Saved");
            //}
            //_studentManager.Delete(student);
            //_studentManager.Update(student.Id);
            //_studentManager.GetAll();
            //_studentManager.GetById(student.Id);


            //foreach (var std in _studentManager.GetAll())
            //{
            //    Console.WriteLine("Name: " + std.Name + " Address: " + std.Address + " Age: " + std.Age);
            //}
            //Console.ReadKey();

            //var student = _studentManager.GetById(2);

            //if (student != null)
            //{

            //    student.RollNo = "004";
            //    student.Name = "Hasan";
            //    student.Address = "Motijhil";
            //    student.Age = 20;
            //}

            //if (_studentManager.Update(student))
            //    Console.WriteLine("Updated");
            //else
            //{
            //    Console.WriteLine("Not Updated");
            //}


            Console.WriteLine("-----------------------------------------------------------");
            int i = 1;
            Console.WriteLine("Sl\t Name \t\t Roll No \t Address \t Age \t\tDepartment");
            foreach (var std in _studentManager.GetAll())
            {

                Console.WriteLine(i + "\t" + std.Name + "\t\t" + std.RollNo + " \t\t " + std.Address + " \t\t " + std.Age + "\t\t" + std.DepartmentId);
                i++;
            }

            Console.ReadKey();


            DepartmentManager _departmentManager = new DepartmentManager();

            Department department = new Department()
            {
                Name = "ENG",
                Students = new List<Student>()
                {
                    new Student()
                    {
                        RollNo = "009",
                        Name = "Mehedi",
                        Address = "Mogbazar",
                        Age = 25
                    },
                    new Student()
                    {
                        RollNo = "010",
                        Name = "Doipayion",
                        Address = "Tikatoly",
                        Age = 30
                    }
                }

            };

            Student student = new Student()
            {
                RollNo = "011",
                Name = "Rahman",
                Address = "Mirpur",
                Age = 20,

            };
            department.Students.Add(student);

            _departmentManager.Add(department);
        }
    }
}
