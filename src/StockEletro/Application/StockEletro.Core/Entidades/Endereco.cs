using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Entidades
{
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }

        public Endereco()
        {

        }

        public Endereco(string cep,string logradouro,string bairro,string localidade,string uf) 
        {
          Cep = cep;
          Logradouro = logradouro;
          Bairro = bairro;
          Localidade = localidade;
          Uf = uf;
                
        
        
        }

        
    }
}
