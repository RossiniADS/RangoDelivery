using RangoDelivery.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class TipoPagamento : Entidade
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public bool Retirar { get; set; }
        public TipoFormaPagamento FormaPagamento { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Venda Venda { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}