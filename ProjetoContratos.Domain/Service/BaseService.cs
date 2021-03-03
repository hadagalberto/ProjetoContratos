using AutoMapper;
using ProjetoContratos.Domain.Interface.Repository;
using ProjetoContratos.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Service
{
    public abstract class BaseService<TViewModel, TEntity> : IBaseService<TViewModel, TEntity>
        where TViewModel : class
        where TEntity : class
    {

        private readonly IBaseRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(TViewModel entity)
        {
            await _repository.CreateAsync(_mapper.Map<TEntity>(entity));
        }

        public async Task DeleteAsync(TViewModel entity)
        {
            await _repository.DeleteAsync(_mapper.Map<TEntity>(entity));
        }

        public async Task<TViewModel> GetAsync(long id)
        {
            return _mapper.Map<TViewModel>(await _repository.GetAsync(id));
        }

        public async Task<ICollection<TViewModel>> ListAsync()
        {
            return _mapper.Map<List<TViewModel>>(await _repository.ListAsync());
        }

        public async Task UpdateAsync(TViewModel entity)
        {
            await _repository.UpdateAsync(_mapper.Map<TEntity>(entity));
        }
    }
}
