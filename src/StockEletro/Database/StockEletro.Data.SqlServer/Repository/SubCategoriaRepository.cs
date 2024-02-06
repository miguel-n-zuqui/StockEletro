using Dapper;
using Microsoft.Data.SqlClient;
using StockEletro.Core.Entidades;
using StockEletro.Core.IRepository;
using StockEletro.Data.SqlServer.Conexoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Data.SqlServer.Repositorios
{
    public class SubCategoriaRepository : ISubCategoriaRepositorio
    {


        public SubCategoria Inserir(SubCategoria subcategoria)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"INSERT INTO [dbo].[Subcategoria]
                            ([Nome]
                             ,[Status]
                             ,[CategoriaId])
                        VALUES
                            (@Nome, 
                          @Status,
                          @CategoriaId)";


                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", subcategoria.Nome);
                    parametros.Add("@status", subcategoria.Status);
                    parametros.Add("@CategoriaId", subcategoria.CategoriaId);
                 

                    var linhasAfetadas = connection.Execute(sql, parametros);
                    subcategoria.Sucesso = linhasAfetadas > 0;
                    return subcategoria;

                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060")
                    subcategoria.MensagemDeErro = "Está categoria já existe";
                subcategoria.Sucesso = false;
                return subcategoria;
                throw ex;
               
            }
        }
        public List<SubCategoria> ObterTodas()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT * FROM SubCategoria";

                    var subcategorias = connection.Query<SubCategoria>(sql);

                    return subcategorias.ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Deletar(int id)
        {

            try
            {

                using (var conexao = new SqlConnection(SqlServerContext.Conexao))
                {
                    conexao.Open();
                    var sql = @"DELETE FROM [dbo].[Subcategoria]
                                WHERE Id = @id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id);
                    var linhasAfetadas = conexao.Execute(sql, parametros);
                    return linhasAfetadas == 1;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public SubCategoria Atualizar(SubCategoria subcategoria, int id)
        {
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.Conexao))
                {
                    conexao.Open();
                    var sql = @"UPDATE [dbo].[Subcategoria]
                           SET [Nome] = @nome
                              ,[Status] = @status
                              ,[CategoriaId] =@CategoriaId
                             WHERE Id = @id";

                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", subcategoria.Nome);
                    parametros.Add("@status", subcategoria.Status);
                    parametros.Add("@CategoriaId", subcategoria.CategoriaId);

                    var linhasAfetadas = conexao.Execute(sql, parametros);
                    subcategoria.Sucesso = linhasAfetadas > 0;
                    return subcategoria;
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060")
                    subcategoria.MensagemDeErro = "Está categoria já existe";
                subcategoria.Sucesso = false;
                return subcategoria;
                throw ex;
                
            }
        }

        public List<Categoria> Pesquisar(string texto)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT [Nome]  FROM[dbo].[Subcategoria] WHERE Nome LIKE @produto";
                    
                    var parametros = new DynamicParameters();
                    parametros.Add("@produto", $"%{texto}%");

                    var resultado = connection.Query<Categoria>(sql, parametros);

                    return resultado.ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
