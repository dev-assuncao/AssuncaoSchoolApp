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
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(SchoolContext context) : base(context)
        {
        }

        public async Task<Subject> ObterAlunoNota(Guid studentId)
        {
            return await schoolContext.Subjects.AsNoTracking().Include(a => a.Student).FirstOrDefaultAsync(x => x.Student.Id == studentId);         
        }

        public async Task<IEnumerable<Subject>> ObterAlunosRetidos()
        {
            return await schoolContext.Subjects.AsNoTracking().Include(a => a.Student).Where(a => a.Student.S)
        }
    }
}
