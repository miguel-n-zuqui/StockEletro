using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using StockEletro.Core.Entidade;
using StockEletro.Core.Repositorios;
using StockEletro.Data.SqlServer.Conexoes;
using StockEletro.Core;
using StockEletro.Core.Entidades;

namespace StockEletro.Data.SqlServer.Repositorios
{
    public class LoginRepository : ILoginRepository
    {
        public bool AtualizarSenha(int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"UPDATE [dbo].[Usuario]
                               SET [Senha] = @senha
                               ,[AlteradoEm] = @alteradoEm
                             WHERE ColaboradorId = @id
                            ";


                    var chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
                    var random = new Random();
                    var senha = new string(
                        Enumerable.Repeat(chars, 8)
                                  .Select(s => s[random.Next(s.Length)])
                                  .ToArray());


                    var parametros = new DynamicParameters();
                    parametros.Add("@senha", senha);
                    parametros.Add("@alteradoEm", DateTime.Now);
                    parametros.Add("@id", id);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ObterPorUsuario(Login user)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                     var sql = "SELECT * FROM [dbo].[Usuario] WHERE Usuario = @nome AND Senha =  @senha";

                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", user.Nome) ;
                    parametros.Add("@senha", user.Senha);

                    var linhasAfetadas = connection.ExecuteScalar(sql, parametros);
                    
                    if (linhasAfetadas != null)
                        return true;
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ProcurarColaboradorPorEmail(string email)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT Id FROM [dbo].[Colaborador] WHERE Email = @email";

                    var parametros = new DynamicParameters();
                    parametros.Add("@email", email);

                    var linhasAfetadas = connection.ExecuteScalar(sql, parametros);

                    if (linhasAfetadas != null)
                        return Convert.ToInt32(linhasAfetadas);
                    return -1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObterPorIdColaborador(int idColaborador)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT *, Usuario AS Nome FROM [dbo].[Usuario] WHERE ColaboradorId = @idColaborador;";

                    var usuario = connection.QueryFirstOrDefault<Usuario>(sql, new { idColaborador });

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
