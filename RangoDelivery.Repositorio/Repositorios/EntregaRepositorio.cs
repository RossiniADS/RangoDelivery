using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class EntregaRepositorio : BaseRepositorio<Entrega>, IEntregaRepositorio
    {
        public EntregaRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }
    }
}
