using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public int EmpresaId { get; set; }
    }
}
