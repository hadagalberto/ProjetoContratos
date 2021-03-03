using ProjetoContratos.Domain.DTO;
using ProjetoContratos.Domain.Entity;
using System.Threading.Tasks;

namespace ProjetoContratos.Domain.Interface.Service
{
    public interface IContratoService : IBaseService<ContratoDto, Contrato>
    {
        Task CreateContratoAsync(CreateContratoDto contrato);
    }
}
