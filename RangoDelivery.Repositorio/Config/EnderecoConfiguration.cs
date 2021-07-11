using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Cep).IsRequired().HasMaxLength(10);
            builder.Property(e => e.Complemento).IsRequired().HasMaxLength(45);

            builder.HasMany(e => e.Cliente_has_enderecos).WithOne(c => c.Endereco);
            builder.HasMany(e => e.Empresas).WithOne(c => c.Endereco);
        }
    }
}
