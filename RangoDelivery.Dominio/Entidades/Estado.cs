using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Estado : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public ICollection<Cidade> Cidades { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
