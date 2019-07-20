using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCApp3.Models.Models;

namespace MVCApp3.DatabaseContext.DatabaseContext
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
