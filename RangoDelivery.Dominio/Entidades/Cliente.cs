using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Cliente : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public char Sexo { get; set; }
        public string Celular { get; set; }
        public bool EhAdministrador { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UrlFoto { get; set; }
        public virtual ICollection<Cliente_has_endereco> Cliente_Has_Enderecos { get; set; }
        public virtual ICollection<TipoPagamento> TipoPagamentos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!Senha.Any())
                AdicionarCritica("Senha não pode ficar vazio");
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Critica - NOME DEVE SER PREENCHIDO");

        }
    }
}
