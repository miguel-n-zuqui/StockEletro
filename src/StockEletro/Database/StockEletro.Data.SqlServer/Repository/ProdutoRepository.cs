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

namespace StockEletro.Data.SqlServer.Repository
{
    public class ProdutoRepository : IProdutoRepositorio
    {
        public Produto Atualizar(Produto produto, int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"UPDATE [dbo].[Produto]
                               SET [Nome] = @nome
                                  ,[Status] = @status
                                  ,[Sku] = @sku
                                  ,[Preco] = @preco
                                  ,[EstoqueAtual] = @estoqueAtual
                                  ,[NivelMinimo] = @nivelMinimo
                                  ,[CategoriaId] = @categoriaId
                                  ,[SubcategoriaId] = @subcategoriaId
                                  WHERE @id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", produto.Nome);
                    parametros.Add("@status", produto.Status);
                    parametros.Add("@sku", produto.SKU);
                    parametros.Add("@preco", produto.Preco);
                    parametros.Add("@estoqueAtual", produto.EstoqueAtual);
                    parametros.Add("@nivelMinimo", produto.NivelMinimo);
                    parametros.Add("@categoriaId", produto.CategoriaId);
                    parametros.Add("@subcategoriaId", produto.SubcategoriaId);
                    parametros.Add("@id", id);



                    var linhasAfetadas = connection.Execute(sql, parametros);
                    produto.Sucesso = linhasAfetadas > 0;
                    return produto;

                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060")
                    produto.MensagemDeErro = "Está categoria já existe";
                produto.Sucesso = false;
                return produto;
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
                    var sql = @"DELETE FROM [dbo].[Produto]
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

        public Produto Inserir(Produto produto)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"INSERT INTO [dbo].[Produto]
                               ([Nome]
                               ,[Status]
                               ,[Sku]
                               ,[Preco]
                               ,[EstoqueInicial]
                               ,[EstoqueEntrada]
                               ,[EstoqueSaida]
                               ,[NivelMinimo]
                               ,[CategoriaId]
                               ,[SubcategoriaId])
                         VALUES
                               (@nome
                                ,@status
                                ,@sku
                                ,@preco
                                ,@estoqueAtual
                                ,@nivelMinimo
                                ,@categoriaId
                                ,@subcategoriaId)";
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", produto.Nome);
                    parametros.Add("@status", produto.Status);
                    parametros.Add("@sku", produto.SKU);
                    parametros.Add("@preco", produto.Preco);
                    parametros.Add("@estoqueAtual", produto.EstoqueAtual);
                    parametros.Add("@nivelMinimo", produto.NivelMinimo);
                    parametros.Add("@categoriaId", produto.CategoriaId);
                    parametros.Add("@subcategoriaId", produto.SubcategoriaId);
                    


                    var linhasAfetadas = connection.Execute(sql, parametros);
                    produto.Sucesso = linhasAfetadas > 0;
                    return produto;

                }
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2146232060")
                    produto.MensagemDeErro = "Está categoria já existe";
                produto.Sucesso = false;
                return produto;
                throw ex;
            }
        }

        public List<Produto> ObterTodas()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"SELECT * FROM Produto ";

                    var produtos = connection.Query<Produto>(sql);

                    return produtos.ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Produto> Filtro(string texto)
        {
            throw new NotImplementedException();
        }

    }
}
