using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class Categoria_has_empresaConfiguration : IEntityTypeConfiguration<Categoria_has_empresa>
    {
        public void Configure(EntityTypeBuilder<Categoria_has_empresa> builder)
        {
            builder.HasKey(c => c.Id);
        }
    }
}
