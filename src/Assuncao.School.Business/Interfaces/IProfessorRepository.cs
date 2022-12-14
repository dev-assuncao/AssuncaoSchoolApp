using Assuncao.School.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Interfaces
{
    public interface IProfessorRepository : IRepository<Professor>
    {
        Task<IEnumerable<Professor>> ObterTurmas(Guid id);
    }
}
