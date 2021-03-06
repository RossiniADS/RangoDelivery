using RangoDelivery.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Contratos
{
    public interface IClienteRepositorio : IBaseRepositorio<Cliente>
    {
        Cliente Obter(string email, string senha);
        Cliente Obter(string email);

    }
}
