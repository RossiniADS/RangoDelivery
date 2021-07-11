using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RangoDelivery.Dominio.Entidades;

namespace RangoDelivery.Repositorio.Config
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Cnpj).IsRequired().HasMaxLength(18);
            builder.Property(e => e.RazaoSocial).IsRequired().HasMaxLength(45);
            builder.Property(e => e.NomeFantasia).IsRequired().HasMaxLength(45);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(45);
            builder.Property(e => e.Senha).IsRequired().HasMaxLength(400);
            builder.Property(e => e.NumeroEndereco).IsRequired().HasMaxLength(45);
            builder.Property(e => e.UrlFoto).IsRequired().HasMaxLength(255);

            builder.HasMany(e => e.Categoria_has_empresas).WithOne(c => c.Empresa);
            builder.HasMany(e => e.Telefones).WithOne(c => c.Empresa);
            builder.HasMany(e => e.Entregas).WithOne(c => c.Empresa);
            builder.HasMany(e => e.Avaliacoes).WithOne(c => c.Empresa);
            builder.HasMany(e => e.Pedidos).WithOne(c => c.Empresa);
        }
    }
}
