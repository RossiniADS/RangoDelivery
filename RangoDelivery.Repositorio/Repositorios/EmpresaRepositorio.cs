using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepositorio
    {
        public EmpresaRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }
    }
}
