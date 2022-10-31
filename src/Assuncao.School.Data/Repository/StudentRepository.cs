using Assuncao.School.Business.Interfaces;
using Assuncao.School.Business.Models;
using Assuncao.School.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Data.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolContext context) : base(context)
        {
        }

        /*public async Task<Student> ObterAlunoNotaMateria(Guid id, Subject idSubject)
        {
            

        }*/
    }
}
