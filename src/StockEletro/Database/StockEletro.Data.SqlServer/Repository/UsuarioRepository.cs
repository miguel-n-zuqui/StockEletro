using Dapper;
using Microsoft.Data.SqlClient;
using StockEletro.Core.Entidades;
using StockEletro.Core.IRepository;
using StockEletro.Data.SqlServer.Conexoes;


namespace StockPhone.DataBase.SqlServer.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public bool Inserir(Usuario usuario)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"INSERT INTO [dbo].[Usuario]
                                           ([Usuario]
                                           ,[Senha]
                                           ,[Status]
                                           ,[ColaboradorId])
                                     VALUES
                                           (@nome

                                           ,@senha
                                           ,@status
                                           ,@idColaborador)";

                    usuario.CriadoEm = DateTime.Now;

                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", usuario.Nome);
                    parametros.Add("@senha", usuario.Senha);
                    parametros.Add("@status", usuario.Status);
                    parametros.Add("@idColaborador", usuario.ColaboradorId);

                    var linhasAfetadas = connection.Execute(sql, parametros);
                    return linhasAfetadas == 1;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool Deletar(int id)
        {
            try
            {

                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    connection.Open();
                    var sql = @"DELETE FROM Usuario
                                WHERE Id = @id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id);
                    var linhasAfetadas = connection.Execute(sql, parametros);
                    return linhasAfetadas == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Atualizar(Usuario usuario, int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"UPDATE [dbo].[Usuario]
                               SET [Usuario] = @nome
                                  ,[Senha] = @senha
                                  ,[Status] = @status
                                  ,[AlteradoEm] = @alteradoEm
                                 WHERE Id = @id";

                    usuario.AlteradoEm = DateTime.Now;

                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", usuario.Nome);
                    parametros.Add("Senha", usuario.Senha);
                    parametros.Add("@status", usuario.Status);
                    parametros.Add("@alteradoEM", usuario.AlteradoEm);
                    parametros.Add("@Id", id);

                    var linhasAfetadas = connection.Execute(sql, parametros);
                    return linhasAfetadas == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Usuario> ObterTodos()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = @"SELECT *, Usuario AS Nome FROM [dbo].[Usuario]";

                    var usuario = connection.Query<Usuario>(sql);

                    return usuario.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public string ObterEmail(int idColaborador)
        {
            using (var connection = new SqlConnection(SqlServerContext.Conexao))
            {
                var sql = @"SELECT Email
                            FROM dbo.[Colaborador] 
                            WHERE Id = @id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", idColaborador);
                var email = connection.QueryFirst<string>(sql, parametros);

                return email.ToString();
            }
        }
    }
}