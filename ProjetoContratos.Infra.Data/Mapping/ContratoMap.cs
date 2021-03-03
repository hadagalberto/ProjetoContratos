using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoContratos.Domain.Entity;

namespace ProjetoContratos.Infra.Data.Mapping
{
    public class ContratoMap : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.DataContratacao).IsRequired();
            builder.Property(c => c.QuantidadeParcelas).IsRequired();
            builder.Property(c => c.ValorFinanciado).IsRequired();


            //Relacionamentos
            builder.HasMany(c => c.Prestacoes)
                .WithOne(p => p.Contrato)
                .HasForeignKey(p => p.IdContrato);
        }
    }
}
