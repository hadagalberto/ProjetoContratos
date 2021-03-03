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
    public class ContratoService : BaseService<ContratoDto, Contrato>, IContratoService
    {
        public ContratoService(IContratoRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
