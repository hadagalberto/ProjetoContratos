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
    public class PrestacaoRepository : BaseRepository<Prestacao>, IPrestacaoRepository
    {

        private readonly ProjetoContratosDbContext _dbContext;

        public PrestacaoRepository(ProjetoContratosDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Prestacao>> ListByContratoAsync(long idContrato)
        {
            return await _dbContext.Set<Prestacao>()
                .AsNoTracking()
                .Where(p => p.IdContrato == idContrato)
                .ToListAsync();
        }
    }
}
