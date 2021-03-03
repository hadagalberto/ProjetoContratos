using AutoMapper;
using ProjetoContratos.Domain.DTO;
using ProjetoContratos.Domain.Entity;
using ProjetoContratos.Domain.Interface.Repository;
using ProjetoContratos.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Service
{
    public class PrestacaoService : BaseService<PrestacaoDto, Prestacao>, IPrestacaoService
    {

        private readonly IPrestacaoRepository _repository;
        private readonly IMapper _mapper;

        public PrestacaoService(IPrestacaoRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<PrestacaoDto>> ListByContratoAsync(long idContrato)
        {
            return _mapper.Map<List<PrestacaoDto>>(await _repository.ListByContratoAsync(idContrato));
        }
    }
}
