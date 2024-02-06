using StockEletro.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Core.Repository
{
    public interface IClienteRepository
    {
        bool Inserir(Cliente cliente);
         
        bool Atualizar(Cliente cliente);
        bool Deletar(Cliente cliente);
        List<Cliente> ObterTodos();
    }
}
