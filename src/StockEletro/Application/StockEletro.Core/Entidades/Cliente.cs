using StockEletro.Core.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Entidades
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string EstadoAtual { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }

        public Cliente() { }
        public Cliente(string nome , string estadoAtual,string cnpj,string cep,string cidade , string bairro, string logradouro, int numero)
        { 
            Nome = nome;
            EstadoAtual = estadoAtual;
            Cnpj = cnpj;
            Cep = cep;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Numero = numero;
        }
    }
}
