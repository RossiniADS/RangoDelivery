using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;
using System.Linq;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }

        public Cliente Obter(string email, string senha)
        {
            return RangoDeliveryContexto.Clientes.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Cliente Obter(string email)
        {
            return RangoDeliveryContexto.Clientes.FirstOrDefault(u => u.Email == email);
        }
    }
}
