using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Interface.Repository
{
    public interface IBaseRepository<TEntity> 
        where TEntity : class
    {

        Task DeleteAsync(TEntity entity);

        Task<ICollection<TEntity>> ListAsync();

        Task<TEntity> GetAsync(long id);

        Task CreateAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

    }
}
