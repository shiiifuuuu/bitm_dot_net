using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DatabaseContext.DatabaseContext;
using WebApp.Model.Model;

namespace WebApp.Repository.Repository
{
    public class StudentRepository
    {
        private ProjectDbContext dbContext = new ProjectDbContext();

        public bool Add(Student student)
        {
            dbContext.Students.Add(student);
            //dbContext.SaveChanges();

            //return true;

            return dbContext.SaveChanges() > 0; //returns true
        }

        public bool Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student student)
        {
            //Method 1
            //Student aStudent = dbContext.Students.FirstOrDefault(c => c.Id == student.Id);

            //if (aStudent !=null)
            //{

            // aStudent.RollNo = student.RollNo;
            // aStudent.Name = student.Name;
            // aStudent.Address = student.Address;
            // aStudent.Age = student.Age;
            //}

            dbContext.Entry(student).State = EntityState.Modified;
            return dbContext.SaveChanges() > 0;
        }

        public List<Student> GetAll()
        {
            return dbContext.Students.ToList();
        }

        public Student GetById(int id)
        {
            Student student = dbContext.Students.FirstOrDefault(c => c.Id == id);
            return student;
        }
    }
}