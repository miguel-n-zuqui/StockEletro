using StockEletro.Core.Entidade;
using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Repositorios
{
    public interface ILoginRepository
    {
        bool ObterPorUsuario(Login user);
        bool AtualizarSenha(int id);
        int ProcurarColaboradorPorEmail(string email);
        Usuario ObterPorIdColaborador(int idColaborador);
    }
}
