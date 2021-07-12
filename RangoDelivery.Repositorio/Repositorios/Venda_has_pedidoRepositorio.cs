using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class Venda_has_pedidoRepositorio : BaseRepositorio<Venda_has_pedido>, IVenda_has_pedidoRepositorio
    {
        public Venda_has_pedidoRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }
    }
}
