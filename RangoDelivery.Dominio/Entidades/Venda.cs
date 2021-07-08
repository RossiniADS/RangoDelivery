using RangoDelivery.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Venda : Entidade
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public StatusEntrega EntregaStatus { get; set; }
        public StatusPagamento PagamentoStatus { get; set; }
        public ICollection<TipoPagamento> TipoPagamentos { get; set; }
        public ICollection<Venda_has_pedido> Venda_has_pedidos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
