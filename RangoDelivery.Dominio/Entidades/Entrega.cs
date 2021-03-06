using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Entrega : Entidade
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public decimal Frete { get; set; }
        public int BairroId { get; set; }
        public virtual Bairro Bairro { get; set; }
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
