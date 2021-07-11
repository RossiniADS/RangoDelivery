using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class Venda_has_pedidoConfiguration : IEntityTypeConfiguration<Venda_has_pedido>
    {
        public void Configure(EntityTypeBuilder<Venda_has_pedido> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Valor).IsRequired();
            builder.Property(v => v.Quantidade).IsRequired();

            builder.HasMany(v => v.Avaliacoes).WithOne(v => v.Venda_Has_Pedido);
        }
    }
}
