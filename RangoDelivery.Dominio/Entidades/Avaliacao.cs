using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Avaliacao : Entidade
    {
        public int Id { get; set; }
        public float Nota { get; set; }
        public string Comentario { get; set; }
        public int Venda_has_pedidoId { get; set; }
        public int EmpresaId { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
