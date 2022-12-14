using Assuncao.School.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuncao.School.Business.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        //Task<IEnumerable<User>> ObterUsersPorTipo();
        Task<User> ObterEnderecoUsuario(Guid userId);
    }
}
