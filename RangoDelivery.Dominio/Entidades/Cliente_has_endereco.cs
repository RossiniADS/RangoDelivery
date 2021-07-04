using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Cliente_has_endereco
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public bool Principal{ get; set; }
        public int ClienteId { get; set; }
        public int EnderecoId { get; set; }
    }
}
