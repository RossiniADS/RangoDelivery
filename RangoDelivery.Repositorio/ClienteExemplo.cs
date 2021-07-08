using RangoDelivery.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Repositorio.Repositorios
{
    public class ClienteExemplo
    {
        public ClienteExemplo()
        {
            var clienteRepositorio = new ClienteRepositorio();
            var produto = new Empresa();
            var cliente = new Cliente();

            clienteRepositorio.Adicionar(cliente);
        }
    }
}
