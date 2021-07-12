using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class Cliente_has_enderecoRepositorio : BaseRepositorio<Cliente_has_endereco>, ICliente_has_enderecoRepositorio
    {
        public Cliente_has_enderecoRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }
    }
}
