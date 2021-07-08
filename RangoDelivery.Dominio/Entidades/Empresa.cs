using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Empresa : Entidade
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string NumeroEndereco{ get; set; }
        public string UrlFoto { get; set; }
        public int EnderecoId { get; set; }
        public ICollection<Categoria_has_empresa> Categoria_has_empresas { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        public ICollection<Entrega> Entregas { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
