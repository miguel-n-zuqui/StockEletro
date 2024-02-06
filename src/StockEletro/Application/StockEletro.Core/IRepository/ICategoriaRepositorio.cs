using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.IRepository
{
    public interface ICategoriaRepositorio
    {
        Categoria Inserir(Categoria categoria);

        Categoria Atualizar(Categoria categoria, int id);

        bool Deletar(int id);

        List<Categoria> Pesquisar(string texto);

        List<Categoria> ObterTodas();

    }
}
