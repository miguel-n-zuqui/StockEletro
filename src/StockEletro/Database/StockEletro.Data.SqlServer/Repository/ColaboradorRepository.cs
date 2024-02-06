using Dapper;
using Microsoft.Data.SqlClient;
using StockEletro.Core.Entidades;
using StockEletro.Core.Repositorios;
using StockEletro.Data.SqlServer.Conexoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockEletro.Data.SqlServer.Repositorio
{
    public class ColaboradorRepository : IColaboradoresRepository
    {


        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog = STOCKELETRO; Persist Security Info=True;User ID = sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";

        public bool Deletar()
        {
            throw new NotImplementedException();
        }

        public bool Incluir(Colaborador colaborador)
        {
            throw new NotImplementedException();
        }

        public Colaborador ObterPorCpf(string cpf)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {


                    var sql = "SELECT  Nome, Status, DataNascimento, Cpf, Email, Telefone FROM Colaborador WHERE Cpf = @userCpf";

                    var parametros = new DynamicParameters();
                    parametros.Add("@userCpf", cpf);

                    var colaborador = connection.QuerySingleOrDefault<Colaborador>(sql, parametros);


                    return colaborador;

                    //var listaColaboradores = connection.Query<Colaborador>(sql, new { userCpf = cpf });
                    //return listaColaboradores.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();

        }

        public List<Colaborador> ObterPorNome(Colaborador colaborador)
        {


            throw new NotImplementedException();
        }

        public List<Colaborador> ObterTodos()
        {


            try
            {

                using (var connection = new SqlConnection(SqlServerContext.Conexao))
                {
                    var sql = "SELECT * FROM Colaborador";

                    var listaColaboradores = connection.Query<Colaborador>(sql);

                    return listaColaboradores.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }


}