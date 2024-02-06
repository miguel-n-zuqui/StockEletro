using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockEletro.Core.Repositorios
{
    public interface IColaboradoresRepository
    {
        bool Incluir(Colaborador colaborador);
        bool Deletar();
        List<Colaborador>ObterTodos();
        Colaborador ObterPorCpf(string cpf);
        List<Colaborador>ObterPorNome(Colaborador colaborador); 
    }
}
