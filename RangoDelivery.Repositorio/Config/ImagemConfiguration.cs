using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class ImagemConfiguration : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Descricao).IsRequired().HasMaxLength(100);
            builder.Property(i => i.ImgUrl).IsRequired().HasMaxLength(255);
            builder.Property(i => i.PedidoId).IsRequired();
        }
    }
}
