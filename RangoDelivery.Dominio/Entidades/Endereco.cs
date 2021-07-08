using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Endereco : Entidade
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public int BairroId { get; set; }
        public ICollection<Cliente_has_endereco> Cliente_has_enderecos { get; set; }
        public ICollection<Empresa> Empresas { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
