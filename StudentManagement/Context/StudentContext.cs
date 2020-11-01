using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Context
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
            
        }
      public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
   
        
    }
}
