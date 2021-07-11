using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Bairro : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Entrega> Entregas { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
