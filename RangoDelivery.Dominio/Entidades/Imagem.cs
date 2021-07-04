using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string ImgUrl { get; set; }
        public int PedidoId { get; set; }
    }
}
