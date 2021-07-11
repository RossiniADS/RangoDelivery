using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class BairroConfiguration : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Nome).IsRequired().HasMaxLength(45);
            builder.Property(b => b.Rua).IsRequired().HasMaxLength(45);

            builder.HasMany(b => b.Enderecos).WithOne(e => e.Bairro);
            builder.HasMany(b => b.Entregas).WithOne(e => e.Bairro);
        }
    }
}
