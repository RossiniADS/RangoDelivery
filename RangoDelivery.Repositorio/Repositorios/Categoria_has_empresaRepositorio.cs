using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class Categoria_has_empresaRepositorio : BaseRepositorio<Categoria_has_empresa>, ICategoria_has_empresaRepositorio
    {
        public Categoria_has_empresaRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {

        }
    }
}
