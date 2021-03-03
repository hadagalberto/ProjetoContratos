using ProjetoContratos.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Interface.Repository
{
    public interface IPrestacaoRepository : IBaseRepository<Prestacao>
    {

        Task<ICollection<Prestacao>> ListByContratoAsync(long idContrato);

    }
}
