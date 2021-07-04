using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Categoria_has_empresa> Categoria_has_empresas { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
