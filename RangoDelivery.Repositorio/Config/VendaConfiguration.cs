using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.DataCompra).IsRequired();
            builder.Property(v => v.Valor).IsRequired();
            builder.Property(v => v.Quantidade).IsRequired();
            builder.Property(v => v.EntregaStatus).IsRequired();
            builder.Property(v => v.PagamentoStatus).IsRequired();

            builder.HasMany(v => v.Venda_has_pedidos).WithOne(v => v.Venda);
            builder.HasMany(v => v.TipoPagamentos).WithOne(v => v.Venda);
        }
    }
}
