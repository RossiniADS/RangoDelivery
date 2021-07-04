using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Enumerados
{
    public enum StatusEntrega
    {
        AguardandoConfirmacao = 0,
        PedidoConfirmado = 1,
        PedidoSaiuParaEntrega = 2,
        PedidoEntregue = 3
    }
}
