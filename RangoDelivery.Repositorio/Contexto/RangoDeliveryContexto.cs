using Microsoft.EntityFrameworkCore;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Dominio.Enumerados;
using RangoDelivery.Repositorio.Config;
using System;

namespace RangoDelivery.Repositorio.Contexto
{
    public class RangoDeliveryContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Categoria_has_empresa> categoria_Has_Empresas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente_has_endereco> Cliente_Has_Enderecos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Entrega> Entregas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoPagamento> TipoPagamentos { get; set; }
        public DbSet<Venda_has_pedido> Venda_Has_Pedidos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        public RangoDeliveryContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new AvaliacaoConfiguration());
            modelBuilder.ApplyConfiguration(new BairroConfiguration());
            modelBuilder.ApplyConfiguration(new Categoria_has_empresaConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new Cliente_has_enderecoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new EntregaConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new ImagemConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new TelefoneConfiguration());
            modelBuilder.ApplyConfiguration(new TipoPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new Venda_has_pedidoConfiguration());
            modelBuilder.ApplyConfiguration(new VendaConfiguration());


            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    Id = 1,
                    Nome = "Rossini G. R. Alves",
                    Email = "rossini@gmail.com",
                    Celular = "(12)981264328",
                    DataNascimento = Convert.ToDateTime("08/03/1996"),
                    Senha = "08031996",
                    Sexo = 'M',
                    UrlFoto = "url"
                },
                new Cliente()
                {
                    Id = 2,
                    Nome = "Renan",
                    Email = "renan@gmail.com",
                    Celular = "(12)981785985",
                    DataNascimento = Convert.ToDateTime("01/02/1998"),
                    Senha = "08031996",
                    Sexo = 'M',
                    UrlFoto = "url"
                });
            modelBuilder.Entity<Empresa>().HasData(
                new Empresa()
                {
                    Id = 1,
                    Cnpj = "1458798568",
                    RazaoSocial = "Alimentos LTDA",
                    NomeFantasia = "Rango delivery",
                    Email = "rango@gmail.com",
                    Senha = "08031996",
                    NumeroEndereco = "98",
                    UrlFoto = "url",
                    EnderecoId = 1
                });
            modelBuilder.Entity<Endereco>().HasData(
                new Endereco()
                {
                    Id = 1,
                    Cep = "12603100",
                    Complemento = "casa",
                    BairroId = 1
                });
            modelBuilder.Entity<Bairro>().HasData(
                new Bairro()
                {
                    Id = 1,
                    Rua = "Rua jovino balbino da silva",
                    Nome = "Vila nunes",
                    CidadeId = 1
                });
            modelBuilder.Entity<Cidade>().HasData(
                new Cidade()
                {
                    Id = 1,
                    Nome = "Lorena",
                    EstadoId = 1
                });
            modelBuilder.Entity<Estado>().HasData(
                new Estado()
                {
                    Id = 1,
                    Nome = "São Paulo",
                    Uf = "SP"
                });


            base.OnModelCreating(modelBuilder);
        }

    }
}
