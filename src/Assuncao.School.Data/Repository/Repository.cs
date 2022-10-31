using Assuncao.School.Business.Interfaces;
using Assuncao.School.Business.Models;
using Assuncao.School.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace Assuncao.School.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly SchoolContext schoolContext;
        protected readonly DbSet<TEntity> Dbset;


        public Repository(SchoolContext context)
        {
            schoolContext = context;
            Dbset = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await Dbset.FirstAsync(x => x.Id == id);
        }

        public virtual async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await Dbset.AsNoTracking().ToListAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            Dbset.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(TEntity entity)
        {
            Dbset.Update(entity);
            await SaveChanges();
        }

        public async Task Remover(Guid id)
        {
            Dbset.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await schoolContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            schoolContext.Dispose();
        }

    }
}
