using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(45);

            builder.HasMany(c => c.Bairros).WithOne(b => b.Cidade);
            builder.HasMany(c => c.Entregas).WithOne(e => e.Cidade);
        }
    }
}
