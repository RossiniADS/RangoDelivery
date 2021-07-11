using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class Cliente_has_enderecoConfiguration : IEntityTypeConfiguration<Cliente_has_endereco>
    {
        public void Configure(EntityTypeBuilder<Cliente_has_endereco> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Numero).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Principal).IsRequired();
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
            //builder.Property(c => c.ClienteId).IsRequired();
            //builder.Property(c => c.EnderecoId).IsRequired();

        }
    }
}
