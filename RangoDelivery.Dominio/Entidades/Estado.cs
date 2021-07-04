﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoDelivery.Dominio.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public ICollection<Cidade> Cidades { get; set; }

    }
}
