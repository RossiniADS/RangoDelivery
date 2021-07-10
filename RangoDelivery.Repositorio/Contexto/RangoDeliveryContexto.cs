using Microsoft.EntityFrameworkCore;
using RangoDelivery.Dominio.Entidades;

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

    }
}
