using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.IRepository
{
    public interface IProdutoRepositorio
    {
        Produto Inserir(Produto produto);

        Produto Atualizar(Produto produto, int id);

        bool Deletar(int id);

        List<Produto> Filtro(string texto);

        List<Produto> ObterTodas();

        

    }
}
