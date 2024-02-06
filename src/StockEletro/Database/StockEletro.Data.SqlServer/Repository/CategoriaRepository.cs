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
    public class CategoriaRepository : ICategoriaRepositorio
    {
       

        public Categoria Inserir(Categoria categoria)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"INSERT INTO [dbo].[Categoria]
                            ([Nome]
                            ,[Status])
                        VALUES
                            (@nome, 
                            @status)";

                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", categoria.Nome);
                    parametros.Add("@status", categoria.Status);


                    var linhasAfetadas = connection.Execute(sql, parametros);
                    categoria.Sucesso = linhasAfetadas >0;
                    return categoria;

                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060")
                    categoria.MensagemDeErro = "Está categoria já existe";
                categoria.Sucesso = false;
                return categoria;
                throw ex;
            }
        }

        public List<Categoria> ObterTodas()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT * FROM Categoria";

                    var categorias = connection.Query<Categoria>(sql);

                    return categorias.ToList();

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
                    var sql = @"DELETE FROM [dbo].[Categoria]
                                    WHERE Id = @id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id);
                    var linhasAfetadas = conexao.Execute(sql, parametros);
                    return linhasAfetadas == 1;
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public Categoria Atualizar(Categoria categoria, int id)
        {
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.Conexao))
                {
                    conexao.Open();
                    var sql = @"UPDATE [dbo].[Categoria]
                              SET [Nome] = @nome
                                 ,[Status] = @status
                             WHERE Id = @id";

                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", categoria.Nome);
                    parametros.Add("@status", categoria.Status);
                    parametros.Add("@Id", id);

                    var linhasAfetadas = conexao.Execute(sql, parametros);
                    categoria.Sucesso = linhasAfetadas > 0;
                    return categoria;
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060")
                    categoria.MensagemDeErro = "Está categoria já existe";
                categoria.Sucesso = false;
                return categoria;
                throw ex;
            }
        }

        public List<Categoria> Pesquisar(string texto)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT [Nome]  FROM[dbo].[Categoria] WHERE Nome LIKE @produto";
                   
                    var parametros = new DynamicParameters();
                    parametros.Add("@produto", $"%{texto}%");

                    var resultado = connection.Query<Categoria>(sql,parametros);

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
