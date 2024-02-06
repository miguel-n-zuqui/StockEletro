using StockEletro.Core.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Entidades
{
    public class Usuario : UsuarioBase
    {
        
        public bool Status { get; set; }
        public int ColaboradorId { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }

        public Usuario() { }
        public Usuario(string nome, string senha, bool status, int colaboradorId) 
        {

            Nome = nome;
            Senha = senha;
            Status = status;
            ColaboradorId = colaboradorId;
            
        }
    }
}
