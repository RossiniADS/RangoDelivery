using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(45);
            builder.Property(p => p.Tipo).IsRequired().HasMaxLength(45);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Caracteristica).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.Valor).IsRequired().HasColumnType("decimal(19,4)");
           
            builder.HasMany(p => p.Venda_has_pedidos).WithOne(v => v.Pedido);
            builder.HasMany(p => p.Imagens).WithOne(v => v.Pedido);

        }
    }
}
