using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Caracteristica { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string NomeArquivo { get; set; }
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Venda_has_pedido> Venda_has_pedidos { get; set; }
        public virtual ICollection<Imagem> Imagens { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome do pedido não foi informado");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Descrição não foi informado");
            }
        }
    }
}
