using Microsoft.EntityFrameworkCore;
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
        private readonly ProjetoContratosDbContext _dbContext;
        public ContratoRepository(ProjetoContratosDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<Contrato> GetAsync(long id)
        {
            return await _dbContext.Contratos.Include(c => c.Prestacoes).FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<ICollection<Contrato>> ListAsync()
        {
            return await _dbContext.Contratos.Include(c => c.Prestacoes).ToListAsync();
        }
    }
}
