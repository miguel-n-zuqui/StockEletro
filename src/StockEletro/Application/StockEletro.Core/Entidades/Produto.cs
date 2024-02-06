using StockEletro.Core.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Entidades
{
    public class Produto: EntidadeBase
    {
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [StringLength(50)]
        [MinLength(4, ErrorMessage = "Produto tem que ter no minimo 4 letras")]
        public string Nome { get; set; }
        public string SKU { get; set; }
        public string Preco { get; set; }
        public string EstoqueAtual{ get; set; }
        public string NivelMinimo { get; set; }
        public int CategoriaId { get; set; }
        public int SubcategoriaId { get; set; }
        public Produto() { }
        public Produto(string nome, bool status, string sku, string preco, string estoqueAtual, string nivelMinimo,int categoria, int subCategoria)
        {
            Nome = nome;
            SKU = sku;
            Preco = preco;
            EstoqueAtual = estoqueAtual;
            NivelMinimo = nivelMinimo;
            CategoriaId = categoria;
            SubcategoriaId = subCategoria;
        }
    }
}
