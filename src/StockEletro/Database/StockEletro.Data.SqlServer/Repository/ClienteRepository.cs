using Dapper;
using Microsoft.Data.SqlClient;
using StockEletro.Core.Entidades;
using StockEletro.Core.Repository;
using StockEletro.Data.SqlServer.Conexoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Data.SqlServer.Repositorios
{
   public class ClienteRepository : IClienteRepository
    {

        public bool Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
            
        }

        public bool Deletar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Cliente cliente)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"INSERT INTO [dbo].[Cargo]
                            ([Nome]
                            ,[Status]
                            ,[CriadoEm]
                            ,[CriadoPor]
                            ,[AlteradoEm]
                            ,[AlteradoPor])
                        VALUES
                            (@nome, 
                            @status, 
                            @criadoEm, 
                            @criadoPor, 
                            @alteradoEm, 
                            @alteradoPor)";

                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.


                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", cliente.Nome);
                    parametros.Add("@status", cliente.Status);


                   /* parametros.Add("@criadoEm", cliente.CriadoEm);
                    parametros.Add("@criadoPor", cliente.CriadoPor);
                    parametros.Add("@alteradoEm", cliente.AlteradoEm);
                    parametros.Add("@alteradoPor", cliente.AlteradoPor);*/

                    var linhasAfetadas = connection.Execute(sql, parametros);
                    
                    return true;

                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
             
            
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
