using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoContratos.Domain.Entity;

namespace ProjetoContratos.Infra.Data.Mapping
{
    public class PrestacaoMap : IEntityTypeConfiguration<Prestacao>
    {
        public void Configure(EntityTypeBuilder<Prestacao> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.DataVencimento).IsRequired();
            builder.Property(e => e.Valor).IsRequired();
            
        }
    }
}
