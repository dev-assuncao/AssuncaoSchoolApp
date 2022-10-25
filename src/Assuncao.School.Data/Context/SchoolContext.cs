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

        DbSet<Address> Addresses { get; set; }
        DbSet<GradeClass> GradeClasses { get; set; }
        DbSet<Professor> Professors { get; set; }
        DbSet<Record> Record { get; set; }
        DbSet<SchoolPlace> Schools { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<User> Users { get; set; }
        
    }
}
