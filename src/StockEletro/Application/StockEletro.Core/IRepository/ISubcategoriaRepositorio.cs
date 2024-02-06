using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.IRepository
{
    public interface ISubCategoriaRepositorio
    {
        SubCategoria Inserir(SubCategoria subcategoria);

        SubCategoria Atualizar(SubCategoria subcategoria, int id);

        bool Deletar(int id);

        List<Categoria> Pesquisar(string texto);

        List<SubCategoria> ObterTodas();
    }
}
