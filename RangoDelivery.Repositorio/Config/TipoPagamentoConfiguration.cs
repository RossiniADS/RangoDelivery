using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class TipoPagamentoConfiguration : IEntityTypeConfiguration<TipoPagamento>
    {
        public void Configure(EntityTypeBuilder<TipoPagamento> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Data).IsRequired();
            builder.Property(t => t.FormaPagamento).IsRequired();
            builder.Property(t => t.Retirar).IsRequired();
        }
    }
}
