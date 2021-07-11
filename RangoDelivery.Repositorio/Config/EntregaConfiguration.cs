using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class EntregaConfiguration : IEntityTypeConfiguration<Entrega>
    {
        public void Configure(EntityTypeBuilder<Entrega> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Ativo).IsRequired();
            builder.Property(e => e.Frete).IsRequired();
        }
    }
}
