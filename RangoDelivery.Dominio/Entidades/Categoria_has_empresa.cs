using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Categoria_has_empresa
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public int EmpresaId { get; set; }
    }
}
