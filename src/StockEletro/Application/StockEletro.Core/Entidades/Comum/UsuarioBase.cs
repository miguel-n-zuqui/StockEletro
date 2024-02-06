using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Entidades.Comum
{
    public abstract class UsuarioBase : EntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
