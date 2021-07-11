using Microsoft.EntityFrameworkCore;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Config;

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

            base.OnModelCreating(modelBuilder);
        }

    }
}
