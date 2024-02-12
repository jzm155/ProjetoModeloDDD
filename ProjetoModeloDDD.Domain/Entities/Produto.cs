using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produto
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public bool Disponivel { get; set; }

        public long ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
