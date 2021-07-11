using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Categoria : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Categoria_has_empresa> Categoria_has_empresas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
