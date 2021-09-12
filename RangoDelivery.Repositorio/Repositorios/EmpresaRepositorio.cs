using RangoDelivery.Dominio.Contratos;
using RangoDelivery.Dominio.Entidades;
using RangoDelivery.Repositorio.Contexto;
using System.Linq;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepositorio
    {
        public EmpresaRepositorio(RangoDeliveryContexto rangoDeliveryContexto) : base(rangoDeliveryContexto)
        {
        }

        public Empresa Obter(string email, string senha)
        {
            return RangoDeliveryContexto.Empresas.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
