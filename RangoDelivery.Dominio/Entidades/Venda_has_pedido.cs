using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Venda_has_pedido
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public int VendaId { get; set; }
        public int PedidoId { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}
