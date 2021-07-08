using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Imagem : Entidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string ImgUrl { get; set; }
        public int PedidoId { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
