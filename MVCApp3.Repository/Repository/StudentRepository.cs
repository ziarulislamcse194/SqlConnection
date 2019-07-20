using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCApp3.DatabaseContext.DatabaseContext;
using MVCApp3.Models.Models;


namespace MVCApp3.Repository.Repository
{
    public class StudentRepository
    {
        StudentDbContext db = new StudentDbContext();

        public bool Add(Student student)
        {
            db.Students.Add(student);
            int saved = db.SaveChanges();

            if (saved > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault(c => c.Id == student.Id);
            int saved = 0;
            if (aStudent != null)
            {
                aStudent.Name = student.Name;
                saved = db.SaveChanges();

            }

            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault(c => c.Id == student.Id);
            db.Students.Remove(aStudent);
            int saved = db.SaveChanges();


            if (saved > 0)
            {
                return true;
            }

            return false;
        }
    }
}
