using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Cidade : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Bairro> Bairros { get; set; }
        public virtual ICollection<Entrega> Entregas { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
