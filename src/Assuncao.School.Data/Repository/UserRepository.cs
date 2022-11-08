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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SchoolContext context) : base(context)
        {
        }

        public async Task<User> ObterEnderecoUsuario(Guid userId)
        {
            return await schoolContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == userId);
        }

        /*public Task<IEnumerable<User>> ObterUsersPorTipo()
        {
            throw new NotImplementedException();
        }*/
    }
}
