using Microsoft.EntityFrameworkCore;
using ProjetoContratos.Domain.Entity;

namespace ProjetoContratos.Infra.Data.Context
{
    public class ProjetoContratosDbContext : DbContext
    {

        public ProjetoContratosDbContext(DbContextOptions<ProjetoContratosDbContext> options) : base(options)
        {
            
        }

        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Prestacao> Prestacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjetoContratosDbContext).Assembly);
        }
    }
}
