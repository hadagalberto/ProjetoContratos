using ProjetoContratos.Domain.DTO;
using ProjetoContratos.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Interface.Service
{
    public interface IPrestacaoService : IBaseService<PrestacaoDto, Prestacao>
    {

        Task<ICollection<PrestacaoDto>> ListByContratoAsync(long idContrato);

    }
}
