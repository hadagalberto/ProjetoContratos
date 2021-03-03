using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Interface.Service
{
    public interface IBaseService<TViewModel, TEntity>
        where TViewModel : class
        where TEntity : class
    {
        Task DeleteAsync(TViewModel entity);

        Task<ICollection<TViewModel>> ListAsync();

        Task<TViewModel> GetAsync(long id);

        Task CreateAsync(TViewModel entity);

        Task UpdateAsync(TViewModel entity);
    }
}
