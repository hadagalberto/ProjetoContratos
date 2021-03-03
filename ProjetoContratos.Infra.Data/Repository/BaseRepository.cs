using Microsoft.EntityFrameworkCore;
using ProjetoContratos.Domain.Interface.Repository;
using ProjetoContratos.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Infra.Data.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        protected DbContext Context { get; }
        protected DbSet<TEntity> EntitySet => Context.Set<TEntity>();

        public BaseRepository(ProjetoContratosDbContext dbContext) 
        {
            Context = dbContext;
        }

        private bool IsAttached(TEntity entity) => (uint)Context.Entry(entity).State > 0U;

        public virtual async Task DeleteAsync(TEntity entity)
        {
            EntitySet.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task<TEntity> GetAsync(long id)
        {
            TEntity entity = await EntitySet.FindAsync(id);
            return entity;
        }

        public virtual async Task CreateAsync(TEntity entity) 
        {
            EntitySet.Add(entity);
            await Context.SaveChangesAsync();
        }


        public virtual async Task UpdateAsync(TEntity entity)
        {
            if (!IsAttached(entity))
                EntitySet.Add(entity);
            int num = await Context.SaveChangesAsync();
        }

        public async Task<ICollection<TEntity>> ListAsync()
        {
            return await EntitySet.ToListAsync();
        }
    }
}
