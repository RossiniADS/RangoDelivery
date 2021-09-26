﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Migrations
{
    [DbContext(typeof(RangoDeliveryContexto))]
    partial class RangoDeliveryContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<float>("Nota")
                        .HasColumnType("float");

                    b.Property<int>("Venda_has_pedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("Venda_has_pedidoId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Bairro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Bairros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CidadeId = 1,
                            Nome = "Vila nunes",
                            Rua = "Rua jovino balbino da silva"
                        });
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Categoria_has_empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("categoria_Has_Empresas");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstadoId = 1,
                            Nome = "Lorena"
                        });
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("text");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char(1)");

                    b.Property<string>("UrlFoto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Celular = "(12)981264328",
                            DataNascimento = new DateTime(1996, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rossini@gmail.com",
                            Nome = "Rossini G. R. Alves",
                            Senha = "08031996",
                            Sexo = "M",
                            UrlFoto = "url"
                        },
                        new
                        {
                            Id = 2,
                            Celular = "(12)981785985",
                            DataNascimento = new DateTime(1998, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "renan@gmail.com",
                            Nome = "Renan",
                            Senha = "08031996",
                            Sexo = "M",
                            UrlFoto = "url"
                        });
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Cliente_has_endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<bool>("Principal")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Cliente_Has_Enderecos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(18)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("NumeroEndereco")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<string>("UrlFoto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Empresas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cnpj = "1458798568",
                            Email = "rango@gmail.com",
                            EnderecoId = 1,
                            NomeFantasia = "Rango delivery",
                            NumeroEndereco = "98",
                            RazaoSocial = "Alimentos LTDA",
                            Senha = "08031996",
                            UrlFoto = "url"
                        });
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BairroId")
                        .HasColumnType("int");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Id");

                    b.HasIndex("BairroId");

                    b.ToTable("Enderecos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BairroId = 1,
                            Cep = "12603100",
                            Complemento = "casa"
                        });
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("BairroId")
                        .HasColumnType("int");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Frete")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("BairroId");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Entregas");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Estados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "São Paulo",
                            Uf = "SP"
                        });
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Imagens");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Caracteristica")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.TipoPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormaPagamento")
                        .HasColumnType("int");

                    b.Property<bool>("Retirar")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VendaId");

                    b.ToTable("TipoPagamentos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EntregaStatus")
                        .HasColumnType("int");

                    b.Property<int>("PagamentoStatus")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Venda_has_pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("VendaId");

                    b.ToTable("Venda_Has_Pedidos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Avaliacao", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Venda_has_pedido", "Venda_Has_Pedido")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("Venda_has_pedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Venda_Has_Pedido");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Bairro", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Cidade", "Cidade")
                        .WithMany("Bairros")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Categoria_has_empresa", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Categoria", "Categoria")
                        .WithMany("Categoria_has_empresas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany("Categoria_has_empresas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Cidade", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Cliente_has_endereco", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Cliente", "Cliente")
                        .WithMany("Cliente_Has_Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Endereco", "Endereco")
                        .WithMany("Cliente_has_enderecos")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Empresa", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Endereco", "Endereco")
                        .WithMany("Empresas")
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Endereco", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Bairro", "Bairro")
                        .WithMany("Enderecos")
                        .HasForeignKey("BairroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bairro");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Entrega", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Bairro", "Bairro")
                        .WithMany("Entregas")
                        .HasForeignKey("BairroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Cidade", "Cidade")
                        .WithMany("Entregas")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany("Entregas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bairro");

                    b.Navigation("Cidade");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Imagem", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Pedido", "Pedido")
                        .WithMany("Imagens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Pedido", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Categoria", "Categoria")
                        .WithMany("Pedidos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany("Pedidos")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Telefone", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany("Telefones")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.TipoPagamento", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Cliente", "Cliente")
                        .WithMany("TipoPagamentos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Venda", "Venda")
                        .WithMany("TipoPagamentos")
                        .HasForeignKey("VendaId");

                    b.Navigation("Cliente");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Venda_has_pedido", b =>
                {
                    b.HasOne("RangoDelivery.Dominio.Entidades.Pedido", "Pedido")
                        .WithMany("Venda_has_pedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoDelivery.Dominio.Entidades.Venda", "Venda")
                        .WithMany("Venda_has_pedidos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Bairro", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Entregas");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Categoria", b =>
                {
                    b.Navigation("Categoria_has_empresas");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Cidade", b =>
                {
                    b.Navigation("Bairros");

                    b.Navigation("Entregas");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Cliente", b =>
                {
                    b.Navigation("Cliente_Has_Enderecos");

                    b.Navigation("TipoPagamentos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Empresa", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Categoria_has_empresas");

                    b.Navigation("Entregas");

                    b.Navigation("Pedidos");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Endereco", b =>
                {
                    b.Navigation("Cliente_has_enderecos");

                    b.Navigation("Empresas");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Estado", b =>
                {
                    b.Navigation("Cidades");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Pedido", b =>
                {
                    b.Navigation("Imagens");

                    b.Navigation("Venda_has_pedidos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Venda", b =>
                {
                    b.Navigation("TipoPagamentos");

                    b.Navigation("Venda_has_pedidos");
                });

            modelBuilder.Entity("RangoDelivery.Dominio.Entidades.Venda_has_pedido", b =>
                {
                    b.Navigation("Avaliacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
