using StockEletro.Core.Entidades.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Entidades
{
    public class SubCategoria:EntidadeBase
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [StringLength(50)]
        [MinLength(4, ErrorMessage = "SubCategoria tem que ter no minimo 4 letras")]
        public string Nome { get; set; }
        public bool Status { get; set; }
        public DateTime CriadoEm { get; set; }
        public int CategoriaId { get; set; }



        public SubCategoria() { }
        public SubCategoria(string nome, bool status, int categoriaId , DateTime criadoEm)
        {
            Nome = nome;
            Status = status;
            CategoriaId = categoriaId;
            CriadoEm = criadoEm;
        }
    }
}
