using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Enumerados
{
    public enum StatusPagamento
    {
        AguardandoConfirmacao = 0,
        PagamentoConfirmado = 1,
        PagamentoNaoEfetuado = 2
    }
}
