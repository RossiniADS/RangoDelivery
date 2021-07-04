using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Bairro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int CidadeId { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Entrega> Entregas { get; set; }


    }
}
