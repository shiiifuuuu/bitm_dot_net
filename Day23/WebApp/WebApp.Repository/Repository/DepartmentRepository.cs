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
    public class DepartmentRepository
    {
        ProjectDbContext dbContext = new ProjectDbContext();
        public bool Add(Department department)
        {
            dbContext.Departments.Add(department);
            //dbContext.SaveChanges();

            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            Department aDepartment = dbContext.Departments.FirstOrDefault(c => c.Id == id);

            dbContext.Departments.Remove(aDepartment);

            return dbContext.SaveChanges() > 0;
        }
        public bool Update(Department department)
        {

            //Method - 2
            dbContext.Entry(department).State = EntityState.Modified;
            return dbContext.SaveChanges() > 0;
        }

        public List<Department> GetAll()
        {
            return dbContext.Departments.ToList();
        }

        public Department GetBy(int id)
        {
            return dbContext.Departments.First(c => c.Id == id);
        }
    }
}
