using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Venda_has_pedido : Entidade
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public int VendaId { get; set; }
        public virtual Venda Venda { get; set; }
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
