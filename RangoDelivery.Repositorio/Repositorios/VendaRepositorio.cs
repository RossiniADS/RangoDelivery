using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class VendaRepositorio : BaseRepositorio<Venda>, IVendaRepositorio
    {
        public VendaRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }
    }
}
