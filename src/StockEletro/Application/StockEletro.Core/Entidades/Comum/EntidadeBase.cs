using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Entidades.Comum
{

    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public bool Sucesso { get; set; }
        public string MensagemDeErro { get; set; }

    }
}
