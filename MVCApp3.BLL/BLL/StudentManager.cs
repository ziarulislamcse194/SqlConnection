using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCApp3.Models.Models;
using MVCApp3.Repository.Repository;

namespace MVCApp3.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();

        public bool Add(Student student)
        {

            return _studentRepository.Add(student);
        }

        public bool Update(Student student)
        {
            return _studentRepository.Update(student);
        }

        public bool Delete(Student student)
        {
            return _studentRepository.Delete(student);
        }


    }
}
