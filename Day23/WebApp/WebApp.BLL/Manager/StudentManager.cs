using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.Repository.Repository;

namespace WebApp.BLL.Manager
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        public bool Add(Student student)
        {
            return _studentRepository.Add(student);
        }

        public bool Delete(Student student)
        {
            return _studentRepository.Delete(student);
        }

        public bool Update(int id)
        {
            return _studentRepository.Update(id);
        }

        public bool GetAll()
        {
            return _studentRepository.GetAll();
        }

        public void GetById(int id)
        {
            return _studentRepository.GetById(id);
        }
    }
}
