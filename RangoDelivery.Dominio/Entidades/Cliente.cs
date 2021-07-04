using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public char Sexo { get; set; }
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UrlFoto { get; set; }
        public ICollection<Cliente_has_endereco> Cliente_Has_Enderecos { get; set; }
        public ICollection<TipoPagamento> TipoPagamentos { get; set; }
    }
}
