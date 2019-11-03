using System;
using System.Collections.Generic;
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

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }

        public bool GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}