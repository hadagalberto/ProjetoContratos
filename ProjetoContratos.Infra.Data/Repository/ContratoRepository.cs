using ProjetoContratos.Domain.Entity;
using ProjetoContratos.Domain.Interface.Repository;
using ProjetoContratos.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContratos.Infra.Data.Repository
{
    public class ContratoRepository : BaseRepository<Contrato>, IContratoRepository
    {
        public ContratoRepository(ProjetoContratosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
