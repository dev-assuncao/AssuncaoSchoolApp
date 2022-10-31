using Assuncao.School.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Data.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions options) : base(options)
        {         
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<GradeClass> GradeClasses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Record> Record { get; set; }
        public DbSet<SchoolPlace> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
