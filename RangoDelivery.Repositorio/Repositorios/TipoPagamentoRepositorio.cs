using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class TipoPagamentoRepositorio : BaseRepositorio<TipoPagamento>, ITipoPagamentoRepositorio
    {
        public TipoPagamentoRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }
    }
}
