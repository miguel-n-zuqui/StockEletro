using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.IRepository
{
    public interface IUsuarioRepository
    {
        bool Inserir(Usuario usuario);
        string ObterEmail(int idColaborador);
        bool Atualizar(Usuario usuario, int id);
        bool Deletar(int id);
        List<Usuario> ObterTodos();

    }
}
