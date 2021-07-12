using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            //Builder utiliza o padrão Fluent
            builder.Property(c => c.Email).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(45).HasColumnType("varchar");
            builder.Property(c => c.Senha).IsRequired().HasMaxLength(400).HasColumnType("text");
            builder.Property(c => c.Sexo).IsRequired().HasMaxLength(1).HasColumnType("char");
            builder.Property(c => c.Celular).IsRequired().HasMaxLength(45);
            builder.Property(c => c.DataNascimento).IsRequired().HasColumnType("Date");
            builder.Property(c => c.UrlFoto).IsRequired().HasMaxLength(255);

            builder.HasMany(c => c.Cliente_Has_Enderecos).WithOne(c => c.Cliente);
            builder.HasMany(c => c.TipoPagamentos).WithOne(t => t.Cliente);

        }
    }
}
