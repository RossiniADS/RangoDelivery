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
        public char Caracteristica { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public int EmpresaId { get; set; }
        public int CategoriaId { get; set; }
        public ICollection<Venda_has_pedido> Venda_has_pedidos { get; set; }
        public ICollection<Imagem> Imagens { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
